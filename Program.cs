// Leo Garcia

// 09-06-2023

// Mini Challenge 1

// I used Console.WriteLine to make the text, used string and Console.ReadLine to save user-generated content, and used said strings in conjuction with Console.ReadWrite to make a tailor-made experience... at least to the extent of changing your name.

// Person who Peer Reviewed your assignment: Liam Garcia
// Very detailed, Went above and beyond.

Console.Clear();

Console.WriteLine("Hello... uh... what's your name again....?");

string userName = Console.ReadLine();

Console.WriteLine("Right, right, your name is " + userName + ", I'm sorry I'm bad with names, and the ADHD certainly isn't helping...");

Console.WriteLine("By the way what are your pronouns? (He, She, They, etc.)");

string primaryPronouns = Console.ReadLine();

Console.WriteLine($"Okay, {primaryPronouns}, And? (Him, Her, Them, etc.)");

string secondaryPronouns = Console.ReadLine();

Console.WriteLine($"Alright, {secondaryPronouns}, And finally? (His, Hers, Theirs, etc.)");

string tertiaryPronouns = Console.ReadLine();

Console.WriteLine($"Got it, so they're {primaryPronouns}, {secondaryPronouns}, and {tertiaryPronouns}... okay, thanks {userName}!");