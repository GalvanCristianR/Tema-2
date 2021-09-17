/*
 * Creado por SharpDevelop.
 * Usuario: Nelida
 * Fecha: 16/9/2021
 * Hora: 17:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tema2_Complejidad
{
	class PruebaAB
	{
		public static void Main(string[] args)
		{
			ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

			ArbolBinario<int> hijoIzquierdo=new ArbolBinario<int>(2);
			hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(3));
			hijoIzquierdo.agregarHijoDerecho(new ArbolBinario<int>(4));
			
			ArbolBinario<int> hijoDerecho=new ArbolBinario<int>(5);
			hijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(6));
			hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(7));
			
			arbolBinarioA.agregarHijoIzquierdo(hijoIzquierdo);
			arbolBinarioA.agregarHijoDerecho(hijoDerecho);

			//arbolBinarioA.preorden();
			//arbolBinarioA.inorden();
			//arbolBinarioA.postorden();
			//arbolBinarioA.recorridoPorNiveles();
			//arbolBinarioA.incluye(0);
			arbolBinarioA.recorridoEntreNiveles(0,1);
			Console.Write("Presione una tecla para concluir la ejecucion . . . ");
			Console.ReadKey(true);
		}
	}
}