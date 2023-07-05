/*
 * AssemblyCheck.cs - Assembly and security checker for Unity PSM
 * Copyright 2015 Josh_Axey
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using UnityEngine;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

public class AssemblyCheck : MonoBehaviour
{
	// Jam our tests in here
	void Start ()
	{
		// Check for ability to call security critical method via Marshal.ReadByte

		// Allocate 1 byte of unmanaged memory.
		IntPtr hGlobal = new IntPtr(0xB00BCAFE);
		
		// Create a new byte. 
		byte b = 1;
		
		Console.WriteLine("Byte written to unmanaged memory: " + b);
		
		// Write the byte to unmanaged memory.
		Marshal.WriteByte(hGlobal, b);
		
		// Read byte from unmanaged memory. 
		byte c = Marshal.ReadByte(hGlobal);
		
		Console.WriteLine("Byte read from unmanaged memory: " + c);
		
		// Free the unmanaged memory.
		Marshal.FreeHGlobal(hGlobal);
		
		Debug.Log("Unmanaged memory was disposed.");
		
		// Check loaded assemblies and print to debug console
		var assemblies = AppDomain.CurrentDomain.GetAssemblies(); foreach (var assem in assemblies) { Debug.Log(assem.FullName); }
	}
}
