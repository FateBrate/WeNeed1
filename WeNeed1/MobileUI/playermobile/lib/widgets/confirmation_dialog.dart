import 'package:flutter/material.dart';

class ConfirmationDialog extends StatelessWidget {
  final String title;
  final String content;
  final String confirmButtonText;
  final String cancelButtonText;
  final VoidCallback onConfirm;

  const ConfirmationDialog({
    super.key,
    required this.title,
    required this.content,
    required this.confirmButtonText,
    required this.cancelButtonText,
    required this.onConfirm,
  });

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: Text(title),
      content: Text(content),
      actions: [
        TextButton(
          onPressed: () => Navigator.of(context).pop(),
          child: Text(cancelButtonText),
        ),
        TextButton(
          onPressed: () {
            Navigator.of(context).pop();
            onConfirm();
          },
          child: Text(confirmButtonText),
        ),
      ],
    );
  }
}
