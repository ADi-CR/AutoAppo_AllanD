using System;
using System.Collections.Generic;
using System.Text;

namespace AutoAppo_AllanD.Services
{
    public static class APIConnection
    {
        //en esta clase definimos el Prefijo de consumo de las rutas de los controladores del API 
        //normalmente los API trabajan con una versión de pruebas y otra en producción 
        //además acá vamos a escribir la info del API Key que necesitamos para podernos validar 

        public static string ProductionURLPrefix = "http://192.168.0.146:45455/api/";
        public static string TestingURLPrefix = "http://192.168.0.146:45455/api/";

        public static string ApiKeyName = "P6ApiKey";
        public static string ApiKeyValue = "AllanDelgadoQWERTYIasdfg654*";

    }
}
