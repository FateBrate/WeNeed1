import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

import '../models/comment.dart';
import '../providers/comment_provider.dart';
import '../widgets/master_screen.dart';
class CommentsScreen extends StatefulWidget {
  final int matchId;

  const CommentsScreen({Key? key, required this.matchId}) : super(key: key);

  @override
  State<CommentsScreen> createState() => _CommentsScreenState();
}

class _CommentsScreenState extends State<CommentsScreen> {
  List<Comment> _comments = [];
  final _controller = TextEditingController();
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _loadComments();
  }

  Future<void> _loadComments() async {
    try {
      final data = await CommentProvider().get(filter: {"matchId": widget.matchId});
      setState(() {
        _comments = data.result;
        _isLoading = false;
      });
    } catch (e) {
      _showError("Greška pri učitavanju komentara.");
    }
  }

  void _showError(String msg) {
    ScaffoldMessenger.of(context).showSnackBar(SnackBar(content: Text(msg)));
  }

  Future<void> _addComment() async {
    final content = _controller.text.trim();
    if (content.isEmpty) return;

    try {
      await CommentProvider().insert({
        "content": content,
        "matchId": widget.matchId,
      });
      _controller.clear();
      _loadComments();
    } catch (e) {
      _showError("Greška pri slanju komentara.");
    }
  }

  @override
  Widget build(BuildContext context) {
    return MobileMasterScreenWidget(
      title: "Komentari",
      child: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : Column(
        children: [
          Expanded(
            child: ListView.builder(
              itemCount: _comments.length,
              itemBuilder: (context, index) {
                final c = _comments[index];
                return Padding(
                  padding: const EdgeInsets.symmetric(vertical: 6.0, horizontal: 8),
                  child: Row(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      CircleAvatar(
                        backgroundImage: c.profilePicture != null
                            ? MemoryImage(
                          base64Decode(
                            c.profilePicture!.contains(',')
                                ? c.profilePicture!.split(',').last
                                : c.profilePicture!,
                          ),
                        )
                            : null,
                        child: c.profilePicture == null ? const Icon(Icons.person) : null,
                      ),
                      const SizedBox(width: 12),
                      Expanded(
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  c.userName ?? "Nepoznat korisnik",
                                  style: const TextStyle(
                                    fontWeight: FontWeight.bold,
                                    fontSize: 14,
                                  ),
                                ),
                                Text(
                                  c.created != null
                                      ? DateFormat('dd.MM.yyyy HH:mm').format(c.created!)
                                      : "Nepoznat datum",
                                  style: const TextStyle(
                                    fontSize: 12,
                                    color: Colors.grey,
                                  ),
                                ),
                              ],
                            ),
                            const SizedBox(height: 6),
                            Container(
                              width: double.infinity,
                              padding: const EdgeInsets.all(12),
                              decoration: BoxDecoration(
                                color: Colors.blueGrey[50],
                                borderRadius: BorderRadius.circular(12),
                              ),
                              child: Text(
                                c.content ?? "",
                                style: const TextStyle(fontSize: 12,
                                    color: Colors.black87

                                ),
                              ),
                            ),
                          ],
                        ),
                      ),
                    ],
                  ),
                );
              },
            ),
          ),
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                Expanded(
                  child: TextField(
                    controller: _controller,
                    decoration: const InputDecoration(
                      hintText: "Dodaj komentar...",
                    ),
                  ),
                ),
                IconButton(
                  icon: const Icon(Icons.send, color: Colors.blue),
                  onPressed: _addComment,
                )
              ],
            ),
          )
        ],
      ),
    );
  }
}

