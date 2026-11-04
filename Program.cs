string[] partyMembers = { "Alice", "Bob", "Charlie", "David", "Eve" };

for (int i = 0; i < partyMembers.Length; i++)
{
    Console.WriteLine($"Party Member {i + 1}: {partyMembers[i]}");
}

partyMembers[1] = "Beran";
Console.WriteLine($"Updated Party Member 2: {partyMembers[1]}");