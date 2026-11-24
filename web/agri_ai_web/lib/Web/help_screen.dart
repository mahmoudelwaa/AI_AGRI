import 'package:flutter/material.dart';

const Color _green = Color(0xFF064E36);
const Color _agri = Color(0xFF087B55);

class HelpScreen extends StatefulWidget {
  const HelpScreen({super.key});

  @override
  State<HelpScreen> createState() => _HelpScreenState();
}

class _HelpScreenState extends State<HelpScreen> {
  final List<Map<String, String>> _faqs = const [
    {
      'q': 'كيف أفحص محصولي؟',
      'a': 'من الشاشة الرئيسية اختار المحصول، ثم اضغط "افحص محصولك الآن" والتقط صورة واضحة للورقة.',
    },
    {
      'q': 'هل النتيجة دقيقة؟',
      'a': 'النتيجة تقديرية وتعتمد على وضوح الصورة. ولو عندك شك، استشير مهندس زراعي.',
    },
    {
      'q': 'كيف أغير بياناتي؟',
      'a': 'من شاشة "حسابي" اختار "تعديل البيانات" وعدّل الاسم أو البريد أو الهاتف.',
    },
    {
      'q': 'نسيت كلمة المرور، ماذا أفعل؟',
      'a': 'من شاشة تسجيل الدخول اضغط "نسيت كلمة المرور" واتبع الخطوات.',
    },
  ];

  final Set<int> _open = {};

  void _contactSupport() {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(content: Text('تم إرسال طلبك للدعم الفني، سنتواصل معك قريباً')),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color(0xFFF4F7F5),
      body: SafeArea(
        child: Column(
          children: [
            Container(
              color: _green,
              padding: const EdgeInsets.fromLTRB(16, 12, 16, 14),
              child: Row(
                children: [
                  IconButton(
                    onPressed: () => Navigator.pop(context),
                    icon: const Icon(Icons.arrow_forward, color: Colors.white),
                  ),
                  const Expanded(
                    child: Text(
                      'المساعدة',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white, fontSize: 18, fontWeight: FontWeight.w700),
                    ),
                  ),
                  const SizedBox(width: 48),
                ],
              ),
            ),
            Expanded(
              child: ListView(
                padding: const EdgeInsets.all(16),
                children: [
                  const Text(
                    'الأسئلة الشائعة',
                    style: TextStyle(fontSize: 16, fontWeight: FontWeight.w700, color: _green),
                  ),
                  const SizedBox(height: 12),
                  for (int i = 0; i < _faqs.length; i++)
                    Container(
                      margin: const EdgeInsets.only(bottom: 10),
                      decoration: BoxDecoration(
                        color: Colors.white,
                        borderRadius: BorderRadius.circular(14),
                        border: Border.all(color: const Color(0xFFE2E8F0)),
                      ),
                      child: Column(
                        children: [
                          ListTile(
                            title: Text(
                              _faqs[i]['q']!,
                              style: const TextStyle(fontSize: 14, fontWeight: FontWeight.w600),
                            ),
                            trailing: Icon(
                              _open.contains(i) ? Icons.expand_less : Icons.expand_more,
                              color: _agri,
                            ),
                            onTap: () {
                              setState(() {
                                _open.contains(i) ? _open.remove(i) : _open.add(i);
                              });
                            },
                          ),
                          if (_open.contains(i))
                            Padding(
                              padding: const EdgeInsets.fromLTRB(16, 0, 16, 14),
                              child: Text(
                                _faqs[i]['a']!,
                                style: const TextStyle(fontSize: 13, color: Color(0xFF475569), height: 1.5),
                              ),
                            ),
                        ],
                      ),
                    ),
                  const SizedBox(height: 20),
                  SizedBox(
                    height: 52,
                    child: ElevatedButton(
                      style: ElevatedButton.styleFrom(
                        backgroundColor: _agri,
                        foregroundColor: Colors.white,
                        shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(14)),
                      ),
                      onPressed: _contactSupport,
                      child: const Text(
                        'راسل الدعم',
                        style: TextStyle(fontSize: 15, fontWeight: FontWeight.w700),
                      ),
                    ),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}