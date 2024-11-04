package Main;

import java.util.Scanner;

public class Patient {
	 // D�claration des attributs
    private int cin;
    private String nom;
    private String groupeSanguin; // A, B, AB, ou O
    private char rhesus; // '+' ou '-'
    private int age;
    private String statutMarital; // Mari�, C�libataire, Divorc� ou Veuf
    private boolean diabetique;
	public int getCin() {
		return cin;
	}
	public void setCin(int cin) {
		this.cin = cin;
	}
	public String getNom() {
		return nom;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}
	public String getGroupeSanguin() {
		return groupeSanguin;
	}
	public void setGroupeSanguin(String groupeSanguin) {
		this.groupeSanguin = groupeSanguin;
	}
	public char getRhesus() {
		return rhesus;
	}
	public void setRhesus(char rhesus) {
		this.rhesus = rhesus;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getStatutMarital() {
		return statutMarital;
	}
	public void setStatutMarital(String statutMarital) {
		this.statutMarital = statutMarital;
	}
	public boolean isDiabetique() {
		return diabetique;
	}
	public void setDiabetique(boolean diabetique) {
		this.diabetique = diabetique;
	}
	@Override
	public String toString() {
		return "Patient [cin=" + cin + ", nom=" + nom + ", groupeSanguin=" + groupeSanguin + ", rhesus=" + rhesus
				+ ", age=" + age + ", statutMarital=" + statutMarital + ", diabetique=" + diabetique + "]";
	}
    
	// Constructeur avec seul param�tre le CIN
    public Patient(int cin) {
        this.cin = cin;
        saisirInfosPatient();
    }

    // �thode pour saisir les informations du patient depuis le clavier
    private void saisirInfosPatient() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Entrez le nom du patient : ");
        this.nom = scanner.nextLine();
        //flag pour la v�rification
        boolean verif=false;
        
        // Saisie et v�rification du groupe sanguin
        //on peut aussi utiliser le DO--while
        while (verif==false) {
            System.out.print("Entrez le groupe sanguin (A, B, AB, O) : ");
            this.groupeSanguin = scanner.nextLine().toUpperCase();
            if (groupeSanguin.equals("A") || groupeSanguin.equals("B") || 
                groupeSanguin.equals("AB") || groupeSanguin.equals("O")) {
                verif=true;
            } else {
                System.out.println("Groupe sanguin invalide. Veuillez entrer A, B, AB ou O.");
            }
        }
        verif=false;

        // Saisie et v�rification du rh�sus
        while (verif==false) {
            System.out.print("Entrez le rh�sus (+ ou -) : ");
            this.rhesus = scanner.next().charAt(0);
            if (rhesus == '+' || rhesus == '-') {
                verif=true;
            } else {
                System.out.println("Rh�sus invalide. Veuillez entrer + ou -.");
            }
        }

        // Saisie et v�rification de l'�ge
        verif=false;
        while (verif==false) {
            System.out.print("Entrez l'�ge du patient : ");
            this.age = scanner.nextInt();
            if (age >= 0) {
                verif=true;
            } else {
                System.out.println("^Age invalide. Veuillez entrer un �ge positif.");
            }
        }

        // Saisie et v�rification du statut marital
        scanner.nextLine(); // Consomme le retour de ligne restant
        while (true) {
            System.out.print("Entrez le statut marital (Marié, Célibataire, Divorcé, Veuf) : ");
            this.statutMarital = scanner.nextLine();
            if (statutMarital.equalsIgnoreCase("Mari�") || 
                statutMarital.equalsIgnoreCase("C�libataire") || 
                statutMarital.equalsIgnoreCase("Divorc�") || 
                statutMarital.equalsIgnoreCase("Veuf")) {
                break;
            } else {
                System.out.println("Statut marital invalide. Veuillez entrer Mari�, C�libataire, Divorc� ou Veuf.");
            }
        }

        // Saisie de l'�tat diab�tique
        System.out.print("Le patient est-il diab�tique ? (true/false) : ");
        this.diabetique = scanner.nextBoolean();
    }

    

}
