using Queues;

Random random = new Random();

CallCenter center = new CallCenter();
center.Call (9090);
center.Call (8080);
center.Call (7070);
center.Call (6060);
center.Call (5050);
center.Call (4040);

while (center.AreWaitingCalls())
{
    IncomingCall call = center.Answer("Mario");
    Console.WriteLine($" {call.Id} de {call.ClientId} atendido por {call.Consultant}");

    Thread.Sleep(random.Next(1000, 10000));

    center.End(call);

    Console.WriteLine($"Chamado {call.Id} de {call.ClientId} encerrado por {call.Consultant}");
    Console.WriteLine($"-- Em: {call.EndTime} ");
}