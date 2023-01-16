using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuisineBreakfast.Models;
public record Breakfast
(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    Uri Image,
    List<string> Savory,
    List<string> Sweet
);