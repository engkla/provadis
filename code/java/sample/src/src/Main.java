package src;

public class Main {

    public Double sum (Double var1, Double var2) {
        return var1 + var2;
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
    }
}
