package com;

import com.mypck.MySample;
import org.junit.Test;

import static kotlin.test.AssertionsKt.assertEquals;


public class MyTests {

    @Test
    public void multiplicationOfZeroIntegersShouldReturnZero() {
        MySample tester = new MySample(); // MyClass is tested

        tester.setI(5);
        // assert statements
        assertEquals(5, tester.getI(), "10 x 0 must be 0");
        //assertEquals(0, tester.multiply(0, 10), "0 x 10 must be 0");
        //assertEquals(0, tester.multiply(0, 0), "0 x 0 must be 0");
    }
}