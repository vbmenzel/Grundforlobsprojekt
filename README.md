# Campus Logon Info

Jeg har kodet dette lille C#-program som en del af mit grundforløbsprojekt. Det er et simpelt værktøj, der er designet til at give en bruger hurtig adgang til information om deres nuværende Windows-session.

## Hvad programmet gør

Når programmet kører, viser det et lille vindue med de mest basale oplysninger:

*   Brugernavn
*   Computernavn
*   Domæne
*   Præcist tidspunkt for logon
*   En tæller, der live-opdaterer, hvor længe sessionen har varet

For at finde det korrekte logon-tidspunkt, har jeg kodet det til at slå brugerens `LastLogon`-tid op i Active Directory.
