﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;  
using System;
using UnityEngine.UI;




public class FileGui : MonoBehaviour {


public Text None;

	private bool Load(string fileName)
	{
		// Handle any problems that might arise when reading the text
		try
		{
			string line;
			// Create a new StreamReader, tell it which file to read and what encoding the file
			// was saved as
			StreamReader theReader = new StreamReader(fileName, Encoding.Default);
			// Immediately clean up the reader after this block of code is done.
			// You generally use the "using" statement for potentially memory-intensive objects
			// instead of relying on garbage collection.
			// (Do not confuse this with the using directive for namespace at the 
			// beginning of a class!)
			using (theReader)
			{
				// While there's lines left in the text file, do this:
				do
				{
					line = theReader.ReadLine();

					if (line != null)
					{
						// Do whatever you need to do with the text line, it's a string now
						// In this example, I split it into arguments based on comma
						// deliniators, then send that array to DoStuff()
						string[] entries = line.Split(',');
						if (entries.Length > 0)
							System.Console.WriteLine(entries);
					}
				}
				while (line != null);
				// Done reading, close the reader and return true to broadcast success    
				theReader.Close();
				return true;
			}
		}
		// If anything broke in the try block, we throw an exception with information
		// on what didn't work
		catch (Exception e)
		{
			System.Console.WriteLine("{0}\n", "puta madre");
			return false;
		}
	}

public void create()
{



	System.IO.File.WriteAllText(Application.persistentDataPath+"armando.txt", "");
}


	public void	denada()
	{
		//string path = "C:\table.txt";
		//	Load(path);

		string text = System.IO.File.ReadAllText(Application.persistentDataPath+"armando.txt");
	//	Console.Write (text);
	//	Debug.Log (text);
	
if(text=="")
None.text= "No List Found";


//Debug.Log("No lists Found");




	}




}

