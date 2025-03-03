import java.util.*;
public class Main {
    public static void main(String[] args) {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        Scanner sc = new Scanner(System.in);
        String line = sc.nextLine();
        int n = Integer.parseInt(line);
        int count = 0;
        for(int i = 0; i < 365; i++)
        {
            if(String.valueOf(i).contains(String.valueOf(n)))
            {
                count += 1;
            }
        }
        System.out.println(count);
        
    }
}