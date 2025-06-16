
string firstName = "Marc";
int age = 23;


switch (age)
{
	case >= 0 and < 18:
        Console.WriteLine("You are a child");
		break;
	case >= 18 and < 66:
        Console.WriteLine("You should have a job");
		break;
	case >= 66:
		Console.WriteLine("Hopefully you are retired or retiring soon.");
		break;
	default:
        Console.WriteLine("Age was not in expect range");
		break;
}


// not evaluating to true or false
//switch (firstName.ToLower())
//{
//    // compare to value on the switch
//    //case "sue":
//    case "marc" or "sue":
//        Console.WriteLine("Hello Professor");
//        break;
//    case "tim":
//        Console.WriteLine("Hello tim");
//        break;
//    default:
//        Console.WriteLine("I don't know you");
//        break;

//}       