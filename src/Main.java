import java.util.*;

public class Main {
    public static void main(String[] args) {

        Notebook model1 = new Notebook(1, 2, 128, "Windows 10", "Asus");
        Notebook model2 = new Notebook(2, 4, 256, "Windows 11", "Acer");
        Notebook model3 = new Notebook(3, 32, 512, "Windows 10", "Toshiba");
        Notebook model4 = new Notebook(4, 16, 256, "Windows 11", "Lenovo");
        System.out.println(model1.toString());

        System.out.println("Выберите интересующий параметр:");
        System.out.println("1 - Оперативная память");
        System.out.println("2 - Память жесткого диска");
        System.out.println("3 - Операционная система");
        System.out.println("4 - Марка ноутбука");
        Scanner scanner = new Scanner(System.in);
        Integer choice = scanner.nextInt();
        if(choice == 1){

            System.out.printf("Значение ОП: ");
            try (Scanner scanner0 = new Scanner(System.in)) {
                Integer ram = scanner0.nextInt();
                if (ram >= 32) {
                    System.out.printf(model1.toString() + "\n" + model2.toString() + "\n" + model3.toString() + "\n" + model4.toString() + "\n");
                } else if (ram <= 32 && ram > 16) {
                    System.out.printf(model1.toString() + "\n" + model2.toString() + "\n" + model4.toString());
                } else if (ram <= 16 && ram > 4) {
                    System.out.printf(model1.toString() + "\n" + model2.toString());
                } else if (ram <= 4) {
                    System.out.printf(model1.toString());
                } else System.out.println("Подходящих нет.");
            }
        }
        else if(choice == 2){

            System.out.printf("Значение памяти SSD: ");
            Integer ssd = scanner.nextInt();
            if(ssd <= 512 && ssd > 256){
                System.out.printf(model3.toString());
            }
            else if(ssd <= 256 && ssd > 128){
                System.out.printf(model2.toString() + "\n" + model4.toString());
            }
            else if(ssd <= 128){
                System.out.printf(model1.toString());
            }
            else System.out.println("Подходящих нет.");

        }
        else if(choice == 3){

            System.out.println("Интересующая ОС: ");
            try (Scanner scanner1 = new Scanner(System.in)) {
                String os = scanner1.nextLine();
                if (os.equals("Windows")) {
                    System.out.printf(model1.toString() + "\n" + model2.toString() + "\n" + model4.toString() + "\n" + model3.toString() + "\n");
                }
                else if (os.equals("Windows 10")) {
                    System.out.printf(model1.toString() + "\n" + model3.toString());
                }
                else if (os.equals("Windows 11")) {
                    System.out.printf(model2.toString() + "\n" + model4.toString());
                }
                else System.out.println("Подходящих нет.");
            }
        }
        else if(choice == 4){

            System.out.println("Напишите марку: ");
            try (Scanner scanner2 = new Scanner(System.in)) {
                String stamp = scanner2.nextLine();
                if (stamp.equals("Asus")) {
                    System.out.printf(model1.toString());
                }
                else if (stamp.equals("Acer")) {
                    System.out.printf(model2.toString());
                }
                else if (stamp.equals("Toshiba")) {
                    System.out.printf(model3.toString());
                }
                else if (stamp.equals("Lenovo")) {
                    System.out.printf(model4.toString());
                }
                else System.out.println("Подходящих нет.");
            }
        }
        scanner.close();
    }

}