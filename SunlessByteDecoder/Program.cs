using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.BargainSerializers;
using SunlessByteDecoder.BinarySerializer.ProspectSerializers;
using SunlessByteDecoder.BinarySerializer.EventSerializers;
using SunlessByteDecoder.BinarySerializer.PersonaSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;

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
                    if (args[0].StartsWith("--decrypt="))
                    {
                        if (args[0].EndsWith(".bytes")) BytesToJsonFile(args[0][10..]);
                        else if (args[0].EndsWith(".json"))
                        {
                            Console.WriteLine("Wrong file extension!");
                            success = false;
                        }
                        else BytesToJsonDirectory(args[0][10..]);
                    }
                    else if (args[0].StartsWith("--encrypt="))
                    {
                        if (args[0].EndsWith(".json")) { }
                        else if (args[0].EndsWith(".bytes"))
                        {
                            Console.WriteLine("Wrong file extension!");
                            success = false;
                        }
                        else { }
                    }
                    else if (args[0].EndsWith(".bytes"))
                    {
                        BytesToJsonFile(args[0]);
                    }
                    else if (args[0].EndsWith(".json"))
                    {
                    }
                    else
                    {
                        BytesToJsonDirectory(args[0]);
                    }
                }
                else if (args.Length == 0)
                {
                    BytesToJsonDirectory(AppDomain.CurrentDomain.BaseDirectory);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Arguments formatted incorrectly!");
                    Console.ForegroundColor = ConsoleColor.White;
                    success = false;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An unhandled exception occurred:");
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.White;
                success = false;
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
                using BinaryReader r = new BinaryReader(File.OpenRead(file));
                using StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", Path.GetFileNameWithoutExtension(file) + ".json"));
                {
                    switch (Path.GetFileNameWithoutExtension(file))
                    {
                        case "areas":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Area.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "bargains":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Bargain.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "domiciles":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Domicile.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "events":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Event.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "exchanges":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Exchange.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "personas":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Persona.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "prospects":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Prospect.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "qualities":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Quality.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        case "settings":
                            Console.WriteLine($"Deserializing {Path.GetFileName(file)}");
                            sw.WriteLine(JsonConvert.SerializeObject(BinarySerializer_Setting.DeserializeCollection(r), Formatting.Indented));
                            continue;
                        default: continue;
                    }
                }
            }
        }

        private static void BytesToJsonFile(string path)
        {
            using BinaryReader r = new BinaryReader(File.OpenRead(path));
            using StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileNameWithoutExtension(path) + ".json"));
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

        }

        private static void JsonToBytesFile(string path)
        {

        }
    }
}
