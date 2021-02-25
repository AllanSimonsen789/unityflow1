# unityflow1
flow1 aflevering

Overall projekt:
Vi har lavet en by med NPC(shadow figuren) der går random rundt i navigations mesh. Der er også lavet en labyrint hvor man kan komme igennem den ved at ændre størrelse med Q & E.
Følg stien over broen for at komme til labyrinten

## Allan
Jeg har arbejdet med Terrain, Navmesh og Scripting som mine emener. 
### Terrain 
Terrain er et værktøj jeg ikke har brugt i unity før og jeg blev ikke skuffet. Fantastisk værktøj og det er noget jeg helt sikkert vil bruge i fremtiden. Om resultatet af første forsøg er kønt kan diskuteres.. Især det at lave realistiske bjerge/bakker var en udfordring. Men tænker det er noget som bliver bedre med tiden eller kan hjælpes på vej af en indisk youtube tutorial. En bedre tekstur til bjerget kunne måske hjælpe lidt på det, ellers syntes jeg paint tool til teksturer var godt. især legede jeg opacity for at få en blødere kant mellem teksturene. Vandet er lavet med en simpel plane med en asset fra asset store, en simpel løsning som fungere så længe vandet kun er til pynt og ikke har implementeret at player skal kunne svømme. Et problem jeg havde var performance efter jeg havde brugt "paint trees" til at lave græs arealer i byen. Det var min bærbar ikke så glad for, gætter på det var mængden af græs som den ikke kunne klare, så nok bedst at holde sig til træer med det tool. Problematikken med paint trees var også den manglende randomness på de træer man placerede, muligvis kan man finde en plugin?
### NavMesh/scripting 
Var en relativ nem opgave. bake funktionen var nem når man lige forstod parametrene. Selve agenten var et lidt størrer problem. både at få animationen til at virke samt den random logik med deres destinationer rundt om i byen. Lige nu er der 30 NPC(shadows) og 25 "waypoints" som bare er tomme gameobjekter med transform. Npc'en vælger et random waypoint fra listen af waypoints, og bruger herefter nav agent set destination funktion. for at gøre det lidt mere udfordrene lavede jeg også at hvis deres destination er foran en "Shop" (de små boder med mad ved siden af brønden) så skal de stå stille i 5 sekunder i modsætning til hvis det bare er et tilfældigt sted i byen. Dette gjorde jeg ved undersøge Tag på det waypoint som var destinationen.
## Patrick
Jeg har lavet en maze. For at komme ud skal man ændre på størrelsen af Shadow, det gøres med Q/E taster. Da size blev ændret var camera manden gået på ferie, så jeg måtte lige kigge på hvordan jeg ændrede offset og pivot. Det tog en del tid at connecte den funktionalitet, med camera scriptet der allerede lå på Shadow, da jeg lige skulle forstå syntax og flow. Der var lidt testen frem og tilbage og det har jeg lært en del af. Jeg er ihvertfald blevet gjort lidt opmærksom på nogle C#/Unity regler og skal lige prøve at pakke javascript regelbogen lidt væk ;)
## Github problemer
Github var en stor problematik. Da vi skulle merge fik vi en masse problemer især med assets som var importeret.. Selvom vi forsøgte ikke at lave ændringer på de samme objekter kunne den ikke merge vores scene.. Tror vi prøver at arbejde i seperate scener i næste aflevering eller hører om vores kærer klassekammerater har fundet en bedre løsning
## Project  Planning
Til projekt planning har vi brugt kanban board i github. Grunden til dette er at man slipper for at bruge forskellige services og derfor højere chance for at man opdatere det. I fremtiden kan vi også overveje at opsætte automatisk flytning på issues når der bliver lavet commit. Vi har ikke brugt det så super meget i dette projekt fordi vi brugte mere tid på at lege individuelt og lærer unity at kende.
