
import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'result_screen.dart';

const Color green = Color(0xFF064E36);

/// Web version: image upload instead of camera scan.
class ScanScreen extends StatefulWidget {
final String cropName;
final String cropImage;

const ScanScreen({super.key, required this.cropName, required this.cropImage});

@override
State<ScanScreen> createState() => _ScanScreenState();
}

class _ScanScreenState extends State<ScanScreen> {
final ImagePicker _picker = ImagePicker();
Uint8List? _bytes;
String? _name;
late String _crop = widget.cropName;
late String _cropImage = widget.cropImage;

static const _crops = [
{'ar': 'القمح', 'img': 'assets/wheat.jpeg'},
{'ar': 'الأرز', 'img': 'assets/rice.jpg'},
{'ar': 'الطماطم', 'img': 'assets/tomato.jpeg'},
];

Future<void> _pick() async {
try {
final picked = await _picker.pickImage(source: ImageSource.gallery, imageQuality: 85);
if (picked == null) return;
final b = await picked.readAsBytes();
if (mounted) setState(() { _bytes = b; _name = picked.name; });
} catch (_) {
if (!mounted) return;
ScaffoldMessenger.of(context).showSnackBar(
const SnackBar(content: Text('تعذر رفع الصورة، حاول مرة أخرى')),
);
}
}

void _start() {
if (_bytes == null) {
ScaffoldMessenger.of(context).showSnackBar(
const SnackBar(content: Text('يرجى رفع صورة للنبات أولاً')),
);
return;
}
Navigator.push(
context,
MaterialPageRoute(
builder: (_) => ResultScreen(cropName: _crop, cropImage: _cropImage),
),
);
}

@override
Widget build(BuildContext context) {
return Scaffold(
appBar: AppBar(
backgroundColor: green,
foregroundColor: Colors.white,
title: const Text('تشخيص المرض', style: TextStyle(fontWeight: FontWeight.w700)),
),
body: SingleChildScrollView(
padding: const EdgeInsets.all(32),
child: LayoutBuilder(builder: (context, c) {
final wide = c.maxWidth > 760;
final left = _uploadCard();
final right = Column(children: [_cropCard(), const SizedBox(height: 20), _tipsCard()]);
return Column(
children: [
wide
? Row(
crossAxisAlignment: CrossAxisAlignment.start,
children: [
Expanded(flex: 3, child: left),
const SizedBox(width: 24),
Expanded(flex: 2, child: right),
],
)
    : Column(children: [left, const SizedBox(height: 20), right]),
const SizedBox(height: 28),
SizedBox(
width: 360,
height: 52,
child: ElevatedButton.icon(
style: ElevatedButton.styleFrom(
backgroundColor: green,
foregroundColor: Colors.white,
shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(14)),
),
onPressed: _start,
icon: const Icon(Icons.biotech),
label: const Text('بدء التشخيص',
style: TextStyle(fontSize: 16, fontWeight: FontWeight.w700)),
),
),
],
);
}),
),

);
}

BoxDecoration get _card => BoxDecoration(
color: Colors.white,
borderRadius: BorderRadius.circular(20),
border: Border.all(color: const Color(0xFFECF5F0)),
);

Widget _uploadCard() {
return Container(
padding: const EdgeInsets.all(24),
decoration: _card,
child: Column(
crossAxisAlignment: CrossAxisAlignment.start,
children: [
const Text('ارفع صورة النبات',
style: TextStyle(color: green, fontSize: 18, fontWeight: FontWeight.w700)),
const SizedBox(height: 4),
const Text('صورة واضحة لورقة النبات المصابة (JPG أو PNG)',
style: TextStyle(color: Color(0xFF6B7280), fontSize: 12)),
const SizedBox(height: 16),
InkWell(
onTap: _pick,
borderRadius: BorderRadius.circular(16),
child: Container(
height: 320,
width: double.infinity,
decoration: BoxDecoration(
color: const Color(0xFFF3FAF6),
borderRadius: BorderRadius.circular(16),
border: Border.all(color: const Color(0xFF087B55), width: 1.5),
),
clipBehavior: Clip.antiAlias,
child: _bytes != null
? Stack(fit: StackFit.expand, children: [
Image.memory(_bytes!, fit: BoxFit.cover),
Positioned(
bottom: 12,
right: 12,
child: Chip(
backgroundColor: Colors.white,
label: Text(_name ?? 'تغيير الصورة'),
avatar: const Icon(Icons.swap_horiz, size: 16),
),
),
])
    : const Column(
mainAxisAlignment: MainAxisAlignment.center,
children: [
Icon(Icons.cloud_upload_outlined, size: 56, color: Color(0xFF087B55)),
SizedBox(height: 12),
Text('اضغط لاختيار صورة من جهازك',
style: TextStyle(color: green, fontWeight: FontWeight.w700)),
],
),
),
),
const SizedBox(height: 14),
OutlinedButton.icon(
onPressed: _pick,
icon: const Icon(Icons.upload_file),
label: Text(_bytes == null ? 'اختيار صورة' : 'تغيير الصورة'),
style: OutlinedButton.styleFrom(foregroundColor: green),
),
],
),
);
}

Widget _cropCard() {
return Container(
padding: const EdgeInsets.all(20),
decoration: _card,
width: double.infinity,
child: Column(
crossAxisAlignment: CrossAxisAlignment.start,
children: [
const Text('نوع المحصول',
style: TextStyle(color: green, fontSize: 16, fontWeight: FontWeight.w700)),
const SizedBox(height: 12),
Wrap(
spacing: 10,
children: [
for (final c in _crops)
ChoiceChip(
label: Text(c['ar']!),
selected: _crop == c['ar'],
selectedColor: const Color(0xFFD1FAE5),
onSelected: (_) => setState(() {
_crop = c['ar']!;
_cropImage = c['img']!;
}),
),

],
),
],
),
);
}

Widget _tipsCard() {
const tips = [
'صوّر الورقة المصابة في إضاءة جيدة',
'اجعل الورقة تملأ معظم الصورة',
'تجنب الصور المهزوزة أو المظلمة',
'ورقة واحدة في كل صورة أفضل',
];
return Container(
padding: const EdgeInsets.all(20),
decoration: BoxDecoration(
color: const Color(0xFFECFDF5),
borderRadius: BorderRadius.circular(20),
),
width: double.infinity,
child: Column(
crossAxisAlignment: CrossAxisAlignment.start,
children: [
const Text('نصائح للحصول على نتيجة دقيقة',
style: TextStyle(color: green, fontSize: 16, fontWeight: FontWeight.w700)),
const SizedBox(height: 10),
for (final t in tips)
Padding(
padding: const EdgeInsets.symmetric(vertical: 4),
child: Row(children: [
const Icon(Icons.check_circle, size: 18, color: Color(0xFF087B55)),
const SizedBox(width: 8),
Expanded(child: Text(t, style: const TextStyle(fontSize: 13))),
]),
),
],
),
);
}
}