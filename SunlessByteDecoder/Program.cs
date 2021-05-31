using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.BargainSerializers;
using SunlessByteDecoder.BinarySerializer.ProspectSerializers;
using SunlessByteDecoder.BinarySerializer.EventSerializers;
using SunlessByteDecoder.BinarySerializer.PersonaSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.BargainClasses;
using SunlessByteDecoder.GameClasses.ProspectClasses;
using SunlessByteDecoder.GameClasses.EventClasses;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;

namespace SunlessByteDecoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool success = true;

            try
            {
                if (args.Length == 1)
                {
                    if (args[0].StartsWith("--deserialize="))
                    {
                        if (args[0].EndsWith(".bytes")) BytesToJsonFile(args[0][14..]);
                        else if (args[0].EndsWith(".json")) Error("Wrong file extension!", ref success);
                        else BytesToJsonDirectory(args[0][14..]);
                    }
                    else if (args[0].StartsWith("--serialize="))
                    {
                        if (args[0].EndsWith(".json")) { }
                        else if (args[0].EndsWith(".bytes")) Error("Wrong file extension!", ref success);
                        else JsonToBytesDirectory(args[0][12..]);
                    }
                    else if (args[0].EndsWith(".bytes")) BytesToJsonFile(args[0]);
                    else if (args[0].EndsWith(".json")) JsonToBytesFile(args[0]);
                    else if (Array.FindIndex(Directory.GetFiles(args[0]), x => x.EndsWith(".bytes")) != -1) BytesToJsonDirectory(args[0]);
                    else if (Array.FindIndex(Directory.GetFiles(args[0]), x => x.EndsWith(".json")) != -1) JsonToBytesDirectory(args[0]);
                    else Error("Could not find valid files in directory!", ref success);
                }
                else if (args.Length == 0)
                {
                    if (Array.FindIndex(Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory), x => x.EndsWith(".bytes")) != -1) 
                        BytesToJsonDirectory(AppDomain.CurrentDomain.BaseDirectory);
                    else if (Array.FindIndex(Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory), x => x.EndsWith(".json")) != -1)
                        JsonToBytesDirectory(AppDomain.CurrentDomain.BaseDirectory);
                    else Error("Could not find valid files in directory!", ref success);
                }
                else Error("Arguments formatted incorrectly!", ref success);
            }
            catch (Exception e)
            {
                Error($"An unhandled exception occurred: \n{e}", ref success);
            }

            if (success) Console.WriteLine("Conversion successful, press any key to exit...");
            else Console.WriteLine("Conversion failed, press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void BytesToJsonDirectory(string path)
        {
            string[] files = Directory.GetFiles(path, "*.bytes");
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"));
            foreach (string file in files)
            {
                BytesToJsonFile(file);
            }
        }

        private static void BytesToJsonFile(string path)
        {
            using BinaryReader r = new BinaryReader(File.OpenRead(path));
            using StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", Path.GetFileNameWithoutExtension(path) + ".json"));
            {
                switch (Path.GetFileNameWithoutExtension(path))
                {
                    case "areas":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Area.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "bargains":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Bargain.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "domiciles":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Domicile.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "events":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Event.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "exchanges":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Exchange.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "personas":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Persona.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "prospects":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Prospect.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "qualities":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Quality.DeserializeCollection(r), Formatting.Indented));
                        return;
                    case "settings":
                        Console.WriteLine($"Deserializing {Path.GetFileName(path)}");
                        sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Setting.DeserializeCollection(r), Formatting.Indented));
                        return;
                    default: return;
                }
            }
        }

        private static void JsonToBytesDirectory(string path)
        {
            string[] files = Directory.GetFiles(path, "*.json");
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"));
            foreach (string file in files)
            {
                JsonToBytesFile(file);
            }
        }

        private static void JsonToBytesFile(string path)
        {
            using BinaryReader r = new BinaryReader(File.OpenRead(path));
            using BinaryWriter bw = new BinaryWriter(File.OpenWrite(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", Path.GetFileNameWithoutExtension(path) + ".bytes")));
            {
                switch (Path.GetFileNameWithoutExtension(path))
                {
                    case "areas":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Area.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Area>>(File.ReadAllText(path)));
                        return;
                    case "bargains":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Bargain.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Bargain>>(File.ReadAllText(path)));
                        return;
                    case "domiciles":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Domicile.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Domicile>>(File.ReadAllText(path)));
                        return;
                    case "events":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Event.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(path)));
                        return;
                    case "exchanges":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Exchange.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Exchange>>(File.ReadAllText(path)));
                        return;
                    case "personas":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Persona.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Persona>>(File.ReadAllText(path)));
                        return;
                    case "prospects":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Prospect.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Prospect>>(File.ReadAllText(path)));
                        return;
                    case "qualities":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Quality.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Quality>>(File.ReadAllText(path)));
                        return;
                    case "settings":
                        Console.WriteLine($"Serializing {Path.GetFileName(path)}");
                        BinarySerializer_Setting.SerializeCollection(bw, JsonConvert.DeserializeObject<List<Setting>>(File.ReadAllText(path)));
                        return;
                    default: return;
                }
            }
        }

        private static void Error(string message, ref bool success)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            success = false;
        }
    }
}
