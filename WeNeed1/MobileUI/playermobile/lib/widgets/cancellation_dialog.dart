import 'package:flutter/material.dart';

class CancellationDialog extends StatefulWidget {
  final String title;
  final String confirmButtonText;
  final String cancelButtonText;
  final void Function(String reason) onConfirm;

  const CancellationDialog({
    super.key,
    required this.title,
    required this.confirmButtonText,
    required this.cancelButtonText,
    required this.onConfirm,
  });

  @override
  State<CancellationDialog> createState() => _CancellationDialogState();
}

class _CancellationDialogState extends State<CancellationDialog> {
  final TextEditingController _controller = TextEditingController();
  String? _errorText;

  void _handleConfirm() {
    final reason = _controller.text.trim();
    if (reason.isEmpty) {
      setState(() {
        _errorText = "Razlog otkazivanja je obavezno polje.";
      });
      return;
    }
    Navigator.of(context).pop();
    widget.onConfirm(reason);
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: Text(widget.title),
      content: TextField(
        controller: _controller,
        maxLines: 3,
        decoration: InputDecoration(
          labelText: "Razlog otkazivanja",
          errorText: _errorText,
          border: OutlineInputBorder(),
        ),
      ),
      actions: [
        TextButton(
          onPressed: () => Navigator.of(context).pop(),
          child: Text(widget.cancelButtonText),
        ),
        TextButton(
          onPressed: _handleConfirm,
          child: Text(widget.confirmButtonText),
        ),
      ],
    );
  }
}
