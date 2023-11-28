using System;

public class Solution
{
    // Méthode qui calcule la distance d'édition entre deux chaine de caratères
    public int MinDistance(string A, string B)
    {
        // Longueur des chaines A et B
        int m = A.Length, n = B.Length;
        // Stocker les resultat intermédiaires dans un tableau
        int[,] dp = new int[m + 1, n + 1];
        
        // Initialisation des valeurs pour les cas de base
        for (int i = 0; i <= m; dp[i, 0] = i++) ;
        for (int j = 0; j <= n; dp[0, j] = j++) ;
        
        // Calcul de la distance pour les sous-chaines
        for (int i = 1; i <= m; i++)
            for (int j = 1; j <= n; j++)
                dp[i, j] = (A[i - 1] == B[j - 1]) ? dp[i - 1, j - 1] : 1 + Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]);

        return dp[m, n];
    }

    public static void Main()
    {
        // Demande à l'utilisateur de renseignez le premier caratère
        Console.WriteLine("Entrez la première chaîne : ");
        string A = Console.ReadLine();
        
        // Demande à l'utilisateur de renseignez le deuxième caratère
        Console.WriteLine("Entrez la deuxième chaîne : ");
        string B = Console.ReadLine();
        
        // Crée un instance de la class Solution et appelle la methode minDistance
        int result = new Solution().MinDistance(A, B);
        
        // Affiche le résultat
        Console.WriteLine("Le nombre minimum d'étapes requises est : " + result);
    }
}
