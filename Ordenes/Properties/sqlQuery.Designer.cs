﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ordenes.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class sqlQuery {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal sqlQuery() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ordenes.Properties.sqlQuery", typeof(sqlQuery).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap iconAPP {
            get {
                object obj = ResourceManager.GetObject("iconAPP", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT ItmCod AS Código,ItmDsc AS Descripción,Secuencial FROM dbo.ItmMae WHERE EmpCod=@CodEmpresa AND {0} LIKE @paramExtra ORDER BY Descripción.
        /// </summary>
        internal static string ord_BuscaMaterial {
            get {
                return ResourceManager.GetString("ord_BuscaMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT dbo.CliSuc.SucNum AS CodSucursal, dbo.Ciudades.CiuNom AS Ciudad, LTRIM(RTRIM((ISNULL(dbo.CliSuc.CliDirPri,&apos;&apos;) +&apos; &apos; + ISNULL(dbo.CliSuc.CliDirNum,&apos;&apos;)+&apos; &apos;+ISNULL(dbo.CliSuc.CliDirSec,&apos;&apos;)))) AS Dirección FROM dbo.CliSuc INNER JOIN dbo.Ciudades ON dbo.CliSuc.CliCiu = dbo.Ciudades.CiuCod AND dbo.CliSuc.CliPrv = dbo.Ciudades.PrvCod AND dbo.CliSuc.CliPai = dbo.Ciudades.PaiCod WHERE (dbo.CliSuc.EmpCod = @CodEmpresa) AND (dbo.CliSuc.CliSec = @CodigoCLI).
        /// </summary>
        internal static string ord_CLIAgregaSUC {
            get {
                return ResourceManager.GetString("ord_CLIAgregaSUC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT TOP 20 Clisec AS Código, Clicedruc AS CIRUC, LTRIM(RTRIM(ISNULL(CliApl,&apos;&apos;)+&apos; &apos;+ISNULL(CliNom,&apos;&apos;))) AS Cliente FROM dbo.climae WHERE (EmpCod = @CodEmpresa) AND {0} LIKE @paramExtra ORDER BY Cliente ASC.
        /// </summary>
        internal static string ord_CLIBuscar {
            get {
                return ResourceManager.GetString("ord_CLIBuscar", resourceCulture);
            }
        }
    }
}
