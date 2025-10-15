﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Exportadores
{
    internal class XMLExportador:IExportador
    {
        public string Exportar(Multa m)
        {
            return $"<Multa><Patente>{m.Patente}</Patente><Vencimiento>{m.Vencimiento:dd/MM/yyyy}</Vencimiento><Importar>{m.Importe:f2}</Importar></Multa>";
        }

        public bool Importar(string data, Multa m)
        {
            Match match = Regex.Match(data, @"<Patente>([a-z]{3}\d{3})</Patente><Vencimiento>(\d{2}/\d{2}/\d{4})</Vencimiento><Importe>(\d+,\d*)</Importe>", RegexOptions.IgnoreCase);

            if (match.Success)
            {
                m.Patente = match.Groups[1].Value;
                m.Vencimiento = DateTime.ParseExact(match.Groups[2].Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
                m.Importe = Convert.ToDouble(match.Groups[3].Value, CultureInfo.InvariantCulture);
                return true;
            }
            return false;
        }
    }
}
