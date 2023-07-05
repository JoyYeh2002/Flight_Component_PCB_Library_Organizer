using OriginalCircuit.AltiumSharp;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//string fileName = "C:\\Users\\joy20\\Folder\\NASA\\07-04_Altium_Sharp\\LQMS_BOB_78.PcbLib";
string fileName = "C:\\Users\\joy20\\Folder\\NASA\\07-04_Altium_Sharp\\Temp_Project_Lib_Test\\test_lib.PcbLib";

// Open a PcbLib file.
	using (var reader = new PcbLibReader())
	{
	    // Read the file.
	    OriginalCircuit.AltiumSharp.PcbLib data = reader.Read(fileName);

	    // Iterate through each component in the library.
	    foreach (var component in data.Items)
	    {
	        // Print information about the component.
	        Console.WriteLine($"Name: {component.Pattern}\n");
            Console.WriteLine($"Description: {component.Description}");
	        Console.WriteLine($"Number of Pads: {component.Pads}");
	        Console.WriteLine($"Number of Primitives: {component.Primitives.Count()}");
	    }

	    // Retrieve settings from the header.
	    OriginalCircuit.AltiumSharp.BasicTypes.Unit _displayUnit = data.Header.DisplayUnit;
	    OriginalCircuit.AltiumSharp.BasicTypes.Coord _coord = data.Header.SnapGridSize;

        Console.WriteLine($"Display Unit: {_displayUnit}");
        Console.WriteLine($"Coord: {_coord}");

	    // OriginalCircuit.AltiumSharp.BasicTypes. = data.Items.Cast<IComponent>().ToList();
	}
