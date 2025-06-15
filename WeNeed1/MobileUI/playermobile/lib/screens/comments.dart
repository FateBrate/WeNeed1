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
                return ListTile(
                  leading: CircleAvatar(
                    backgroundImage: c.profilePicture != null
                        ? MemoryImage(
                      // Remove the data URI prefix if exists, decode only the base64 part
                      base64Decode(
                        c.profilePicture!.contains(',')
                            ? c.profilePicture!.split(',').last
                            : c.profilePicture!,
                      ),
                    )
                        : null,
                    child: c.profilePicture == null
                        ? const Icon(Icons.person)
                        : null,
                  ),
                  title: Text(c.userName ?? "Nepoznat korisnik"),
                  subtitle: Text(c.content ?? ""),
                  trailing: Text(
                    c.created != null
                        ? DateFormat('dd.MM.yyyy HH:mm').format(c.created!)
                        : "Nepoznat datum",
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

