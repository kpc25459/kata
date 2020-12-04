import 'dart:math';
import 'package:dart/isSquare.dart';
import 'package:test/test.dart';

void main() {
  test('should work for some examples', () {
    expect(isSquare(-1), isFalse);
    expect(isSquare(0), isTrue);
    expect(isSquare(3), isFalse);
    expect(isSquare(4), isTrue);
    expect(isSquare(25), isTrue);
    expect(isSquare(26), isFalse);
  });

  test('should work for random square numbers', () {
    var r = Random();
    List.generate(100, (i) => i).forEach((n) {
      var x = r.nextInt(65520);
      expect(isSquare(x * x), isTrue);
    });
  });
}
