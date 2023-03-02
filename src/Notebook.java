
public class Notebook {
    int id;
    int ram;
    int ssd;
    String os;
    String stamp;

    public Notebook(int id, int ram, int ssd, String os, String stamp){
        this.id = id;
        this.ram = ram;
        this.ssd = ssd;
        this.os = os;
        this.stamp = stamp;
    }

    public String toString() {
        return String.format("id: %d, ram: %d ГБ, ssd: %d ГБ, OS: %s, stamp: %s", id, ram, ssd, os, stamp);
    }

    public boolean equals(Object o) {
        Notebook t = (Notebook) o;
        return id == t.id;
    }
}