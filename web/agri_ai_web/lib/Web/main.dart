
import 'package:flutter/material.dart';
import 'login_screen.dart';

void main() => runApp(const AgriAIApp());

class AgriAIApp extends StatelessWidget {
const AgriAIApp({super.key});

@override
Widget build(BuildContext context) {
return MaterialApp(
debugShowCheckedModeBanner: false,
theme: ThemeData(
useMaterial3: true,
scaffoldBackgroundColor: const Color(0xFFF7FAF8),
),
builder: (context, child) => Directionality(
textDirection: TextDirection.rtl,
child: ColoredBox(
color: const Color(0xFFE9F1EC),
child: Center(
child: ConstrainedBox(
constraints: const BoxConstraints(maxWidth: 1100),
child: Material(
elevation: 0,
color: const Color(0xFFF7FAF8),
child: child!,
),
),
),
),
),
home: const LoginScreen(),
);
}
}