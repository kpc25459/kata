package net.dev.codewars

fun createPhoneNumber(str: IntArray): String = String.format("(000) 000-0000", str)

fun getCount1(str: String): Int {
    var vowelCount = 0

    val vowels = listOf('a', 'e', 'i', 'o', 'u')

    for (c in str) {
        if (vowels.contains(c))
            vowelCount++
    }

    return vowelCount
}

fun getCount2(str: String): Int = str.filter { it in listOf('a', 'e', 'i', 'o', 'u') }.length

fun getCount3(str: String): Int = str.count { it in "aeiou" }

fun sumOfPositives(numbers: IntArray): Int = numbers.filter { it > 0 }.sum()

fun makeNegative(x: Int): Int = if (x > 0) -x else x

fun opposite(number: Int): Int = -number


fun removeChar(str: String): String = str.substring(1, str.length - 1)

fun numberToString(num: Int): String = num.toString()

fun repeatStr(r: Int, str: String): String = str.repeat(r)

fun summation(n: Int): Int {

    var sum = 0;
    for (x in 1..n)
        sum += x

    return sum;
}

fun summation2(n: Int): Int = (1..n).sum()


fun noSpace(x: String): String = x.replace(" ", "")

fun digitize(n: Long): IntArray = n.toString().reversed().map { it.code - 48 }.toIntArray()

fun findSmallestInt(nums: List<Int>): Int = nums.minOrNull()!!

fun invert(arr: IntArray): IntArray = arr.map { -it }.toIntArray()

fun grow(arr: IntArray): Int = arr.fold(1) { x, y -> x * y }
fun grow2(arr: IntArray): Int = arr.reduce { x, y -> x * y }

fun reverseSeq(n: Int): List<Int> = (1..n).reversed().toList()
fun reverseSeq2(n: Int): List<Int> = (n downTo 1).toList()

fun greet(name: String): String = "Hello, $name how are you doing today?"

fun countPositivesSumNegatives(input: Array<Int>?): Array<Int> {
    if (input.isNullOrEmpty())
        return arrayOf()

    return arrayOf(input.count { it > 0 }, input.filter { it < 0 }.sum())
}

data class Node(val data: Any?, val next: Node? = null)

fun lastIndexOf(head: Node?, value: Any): Int {

    head ?: return -1

    val list = mutableListOf<Any>()

    var current = head
    while (current != null) {

        current.data?.let { list.add(it) }

        current = current.next
    }

    return list.lastIndexOf(value)
}

fun oddCount(n: Int): Int = (1 until n).count { it % 2 != 0 }

fun loveFun(flowerA: Int, flowerB: Int): Boolean = (flowerA % 2 == 0 && flowerB % 2 != 0) || (flowerA % 2 != 0 && flowerB % 2 == 0)

fun stringToNumber(str: String): Int = str.toInt()

fun simpleMultiplication(n: Int): Int = if (n % 2 == 0) n * 8 else n * 9

fun calculateYears(years: Int): Array<Int> {

    fun calc(multiplier: Int) = when (years) {
        1 -> 15
        2 -> 24
        else -> multiplier * (years - 2) + 24
    }

    return arrayOf(years, calc(4), calc(5));
}

fun getAge(yearsOld: String): Int = yearsOld.substringBefore(' ').toInt()

fun maps(x: IntArray): IntArray = x.map { it * 2 }.toIntArray()

fun areaOrPerimeter(l: Int, w: Int): Int = if (l == w) l * w else l * 2 + w * 2

object Reverse {
    fun reverseWords(str: String): String = str.split(' ').reversed().joinToString(" ")
}


fun points(games: List<String>): Int {
    var sum = 0
    for (game in games) {
        val split = game.split(":")
        val x = split[0];
        val y = split[1];

        if (x == y) sum += 1
        else if (x > y) sum += 3
    }
    return sum
}