using Asynkron.Models;


// See https://aka.ms/new-console-template for more information


//Når vi ber vår klient å lage en ny tråd, kan vi også mate den en metode / oppgave den skal jobbe med. 
Thread newThread = new Thread(WriteNewThread);
newThread.Start();

//Etter vi har laget en tråd, og startet execution på den tråden, kan vi nå fortsette å gjøre arbeid på hovedtråden vår. 
for (int i = 0; i < 1000; i++) Console.WriteLine(i);


//Hjelpemetode som skal kjøres på sidetråden. 
static void WriteNewThread()
{
    for (int i  = 1000; i > 0; i--) Console.WriteLine(i);
}

//Vi kan se for oss at vi får vårt program til å lage et eget subprogram som kjører parallellt på maskinen vår.
//Det er en executionpath som kjører uavhenging av de andre vi har, så dette er IKKE det samme som conditional branching.

AsyncronCounter.CountWithThreads();


//Vi kan nå waite for resultatet av vår task completion source method.
AsyncronCounter.CountWithTaskCompletionSource().Wait();

//Vi kan her også awaite vår CountWithAsyncAwait.
await AsyncronCounter.CountWithAsyncAwait();