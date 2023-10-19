# Super Hero Quotes

1. Start API:

```bash
$ dotnet run --project SuperHeroQuotes.Api/SuperHeroQuotes.Api.csproj
```

2. Start Frontend

```bash
$ cd SuperHeroQuotes.Frontend/ && npm run dev
```

3. Open http://localhost:5173/

# Teknologi valg

Der er her anvendt et simpelt .NET 6 WebApi. Det kunne sagtens være en nyere version, men det giver ikke nogen forskel i selve implmenteringen

Valget er faldet på et "klassisk" WebApi og ikke et minimal api, for at gøre det mest overskueligt.

# Forbedrings muligheder

Istedet for at indlæse quotes fra en fil, vil det give mening at gemme disse i en NoSQL database. Dette vil muliggøre at tilføje yderligere quotes. For at implementere dette skal QuoteService ændres til at indlæse data fra ekstern kilde og eventuelt gemmes i en lokal cache for at undgå opslag i extern kilde konstant.

# Udvidelse med flere systemer

API'et er lavet således at både quote og name bliver sendt med i payload. 

Det vil derfor være muligt at lave andre systemer, der kan bruges name info til at identicere hvem der har udtalt et bestemt citat.

