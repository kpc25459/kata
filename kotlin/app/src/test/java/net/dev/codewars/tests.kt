package net.dev.codewars

import org.junit.Assert.*
import org.junit.Test

class SumOfPositivesTests {
    @Test
    fun testSumOfPositives() {
        assertEquals(15, sumOfPositives(intArrayOf(1, 2, 3, 4, 5)))
        assertEquals(13, sumOfPositives(intArrayOf(1, -2, 3, 4, 5)))
        assertEquals(0, sumOfPositives(intArrayOf()))
        assertEquals(0, sumOfPositives(intArrayOf(-1, -2, -3, -4, -5)))
        assertEquals(9, sumOfPositives(intArrayOf(-1, 2, 3, 4, -5)))
    }

    @Test
    fun testCreatePhoneNumber1() {
        assertEquals("(123) 456-7890", createPhoneNumber(intArrayOf(1, 2, 3, 4, 5, 6, 7, 8, 9, 0)))
    }

    @Test
    fun testCreatePhoneNumber2() {
        assertEquals("(111) 111-1111", createPhoneNumber(intArrayOf(1, 1, 1, 1, 1, 1, 1, 1, 1, 1)))
    }

    @Test
    fun testGetCount1() {
        assertEquals(5, getCount1("abracadabra"))
        assertEquals(1, getCount1("test"))
        assertEquals(3, getCount1("example"))
    }

    @Test
    fun testGetCount2() {
        assertEquals(5, getCount2("abracadabra"))
        assertEquals(1, getCount2("test"))
        assertEquals(3, getCount2("example"))
    }

    @Test
    fun testGetCount3() {
        assertEquals(5, getCount3("abracadabra"))
        assertEquals(1, getCount3("test"))
        assertEquals(3, getCount3("example"))
    }

    @Test
    fun testDigitalize() {
        assertArrayEquals(intArrayOf(1, 3, 2, 5, 3), digitize(35231))
        assertArrayEquals(intArrayOf(0), digitize(0))
    }


    @Test
    fun testGrow() {
        assertEquals(6, grow(intArrayOf(1, 2, 3)))
        assertEquals(16, grow(intArrayOf(4, 1, 1, 1, 4)))
        assertEquals(64, grow(intArrayOf(2, 2, 2, 2, 2, 2)))
    }

    @Test
    fun testGrow2() {
        assertEquals(6, grow2(intArrayOf(1, 2, 3)))
        assertEquals(16, grow2(intArrayOf(4, 1, 1, 1, 4)))
        assertEquals(64, grow2(intArrayOf(2, 2, 2, 2, 2, 2)))
    }

    @Test
    fun `Basic tests`() {
        assertEquals(7, oddCount(15))
        assertEquals(7511, oddCount(15023))
    }

    @Test
    fun exampleTests() {
        assertTrue(loveFun(1, 4))
        assertFalse(loveFun(2, 2))
        assertTrue(loveFun(0, 1))
        assertFalse(loveFun(0, 0))
    }

    @Test
    fun testEven() {
        assertEquals(9, simpleMultiplication(1));
        assertEquals(27, simpleMultiplication(3));
    }

    @Test
    fun testOdd() {
        assertEquals(16, simpleMultiplication(2));
        assertEquals(32, simpleMultiplication(4));
    }

    @Test
    fun `one year`() {
        assertArrayEquals(arrayOf(1, 15, 15), calculateYears(1));
    }

    @Test
    fun `two years`() {
        assertArrayEquals(arrayOf(2, 24, 24), calculateYears(2));
    }

    @Test
    fun `ten years`() {
        assertArrayEquals(arrayOf(10, 56, 64), calculateYears(10));
    }

    @Test
    fun sample() {
        assertEquals("eating like I", Reverse.reverseWords("I like eating"))
        assertEquals("flying like I", Reverse.reverseWords("I like flying"))
        assertEquals("nice is world The", Reverse.reverseWords("The world is nice"))
    }


    @Test
    fun basicTests() {
        printAndAssert(30, listOf("1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3"));
        printAndAssert(10, listOf("1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4"));
        printAndAssert(0, listOf("0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4"));
        printAndAssert(15, listOf("1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4"));
        printAndAssert(12, listOf("1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4"));
    }

    private fun printAndAssert(expected: Int, games: List<String>) {
        println("Testing for games: $games")
        assertEquals(expected, points(games))
    }


    @Test
    fun dutyFreeTests() {
        //assertEquals(166, dutyFree(12, 50, 1000))
        assertEquals(294, dutyFree(17, 10, 500))
        assertEquals(357, dutyFree(24, 35, 3000))
        assertEquals(60, dutyFree(377, 40, 9048))
        assertEquals(10, dutyFree(2479, 51, 13390))
    }

    @Test
    fun twiceAsOldTests() {
        assertEquals(22, twiceAsOld(36, 7))
        assertEquals(5, twiceAsOld(55, 30))
        assertEquals(0, twiceAsOld(42, 21))
        assertEquals(20, twiceAsOld(22, 1))
        assertEquals(29, twiceAsOld(29, 0))
    }

    @Test
    fun testLiters() {
        assertEquals(1, litres(2.0))
        assertEquals(0, litres(1.4))
        assertEquals(6, litres(12.3))
        assertEquals(0, litres(0.82))
        assertEquals(5, litres(11.8))
        assertEquals(893, litres(1787.0))
        assertEquals(0, litres(0.0))
    }

    @Test
    public fun test_1() {
        assertEquals(10, sum(listOf(5, "5")));
    }

    @Test
    public fun test_2() {
        assertEquals(22, sum(listOf(9, 3, "7", "3")));
    }

    @Test
    public fun test_3() {
        assertEquals(42, sum(listOf("5", "0", 9, 3, 2, 1, "9", 6, 7)));
    }

    @Test
    public fun test_4() {
        assertEquals(41, sum(listOf("3", 6, 6, 0, "5", 8, 5, "6", 2, "0")));
    }

    @Test
    public fun test_5() {
        assertEquals(45, sum(listOf("1", "5", "8", 8, 9, 9, 2, "3")));
    }

    @Test
    public fun test_6() {
        assertEquals(41, sum(listOf("3", 6, 6, 0, "5", 8, 5, "6", 2, "0")));
    }

    @Test
    public fun test_7() {
        assertEquals(61, sum(listOf(8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7)));
    }

    @Test
    fun pastTests() {
        assertEquals(61000, past(0, 1, 1))
        assertEquals(3661000, past(1, 1, 1))
        assertEquals(0, past(0, 0, 0))
        assertEquals(3601000, past(1, 0, 1))
        assertEquals(3600000, past(1, 0, 0))
    }
}

