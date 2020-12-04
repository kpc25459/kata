import 'dart:math' as math;

/// https://www.codewars.com/kata/54c27a33fb7da0db0100040e/dart
bool isSquare(n) {
  var sqrt = math.sqrt(n);
  return sqrt is int || sqrt == sqrt.roundToDouble();
}