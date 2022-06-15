using System;
using System.Linq;
using Core;
using Core.ApiConnection;
using Core.WebService;

namespace Api
{
    public class ExtendedBiObject<TSelenium> : BiObject<TSelenium> where TSelenium : Wrapper, new()
    {
        public ExtendedBiObject(Gate source) : base(source) { }

        public string[][] ExportKeys()
        {
            var screenId = new TSelenium().ScreenId;
            var content = Source.GetSchema(screenId);
            var keyCommands = content.Containers[0].ServiceCommands.OfType<Key>().Select(_ => content.Containers[0].Fields.First(__ => __.FieldName == _.FieldName && __.ObjectName == _.ObjectName)).Cast<Command>();
            if (!keyCommands.Any()) return Array.Empty<string[]>();
            return Source.Export(screenId, content.Containers.SelectMany(_ => _.ServiceCommands).OfType<EveryValue>().Union(keyCommands).ToArray(), Array.Empty<Core.WebService.Filter>(), 0, false, true);
        }
    }

    public class ApiFactory
    {
        public static ExtendedBiObject<T> Get<T>(Gate source) where T : Wrapper, new()
        {
            return new ExtendedBiObject<T>(source);
        }

        public static ExtendedBiObject<T> Get<T>() where T : Wrapper, new()
        {
            return new ExtendedBiObject<T>(ApiConnection.Source);
        }
    }
}
