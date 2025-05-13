import 'package:flutter/material.dart';

enum SnackbarType { success, error }

class CustomSnackbar {
  static void show(BuildContext context, String message, SnackbarType type) {
    final Color backgroundColor;
    switch (type) {
      case SnackbarType.success:
        backgroundColor = Colors.green;
        break;
      case SnackbarType.error:
        backgroundColor = Colors.red;
        break;
    }

    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(
          message,
          style: const TextStyle(color: Colors.white),
        ),
        backgroundColor: backgroundColor,
        duration: const Duration(seconds: 3),
        behavior: SnackBarBehavior.floating,
      ),
    );
  }
}
