package com.provadis;

import java.lang.reflect.Array;
import java.util.Arrays;

public class Main {

    public static void testArrayRueckgabe(int[] intArray) {
        for (int i = 0;i<intArray.length;i++) {
            intArray[i] += 1;
        }

    }

    public static void testArray (int... i) {
        // int... ist eine Variable Parameterliste
        for (int x : i) {
            System.out.println(x);
        }
        Arrays.sort(i);
        System.out.println(Arrays.binarySearch(i,2));
        System.out.println(Arrays.binarySearch(i,10));
    }
    public static void main(String[] args) {
        int I = 4;

        Integer i = null;
        Integer[] intArray = new Integer[5];
        testArray(1,3,4,2,5,6,7);
        int[] myArray = {1,2,3,4,5};
        testArrayRueckgabe(myArray);
        for (int x : myArray) {
            System.out.println(x);
        }

    }
}
