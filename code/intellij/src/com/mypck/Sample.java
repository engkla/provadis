package com.mypck;

public class Sample {

    public Double sum (Double var1, Double var2) {
        return var1 + var2;
    }

    public static void doEndlosSchleife(){
        int i = 0;
        for (;;) {
            i++;
            if (i==100) break;
        }
        System.out.println("i="+i);
    }

    public static void main(String[] args) {
        int i=5, j=10, k=15;
        double x=2.795, y=2.205;
        boolean b = true;
        b= (x>--i ) ^ (x*3 > --k);

        if (b) {
            System.out.println("true");
        } else {
            System.out.println("false");
        }
        doEndlosSchleife();

        // add ; at EOL -> STRG+Shift+Enter
        MySample mySample = new MySample();
        mySample.setI(5);
        System.out.println(mySample.getI());
    }
}
