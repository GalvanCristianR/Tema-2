/*
 * Creado por SharpDevelop.
 * Usuario: Nelida
 * Fecha: 16/9/2021
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tema2_Complejidad
{
	public class ArbolBinario<T>
	{
		
	
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
		}
		
		public void postorden() {
			
			
		}
		
		public void preorden() {
			Console.Write(this.getDatoRaiz());
			
			if(this.getHijoIzquierdo() !=null){
				getHijoIzquierdo().preorden();
			}
			if (this.getHijoDerecho() != null){
				getHijoDerecho().preorden();
				
			}
			
		}
		
		
		
		public void recorridoPorNiveles() {
			Cola<ArbolBinario<T>> q = new Cola<ArbolBinario<T>>();
			q.encolar(this);
			int nivelActual=0;
			while (!q.esVacia()){
				
				int elementoNivel=q.cantElem();
				Console.WriteLine("Nivel {0}:", nivelActual++);
				while(elementoNivel-->0){
					ArbolBinario<T> nodo=q.desencolar();
					Console.Write(nodo.getDatoRaiz() +" ");
					if (nodo.getHijoDerecho() !=null){
						q.encolar(nodo.getHijoDerecho());
					}
				
					if (nodo.getHijoIzquierdo() !=null){
						q.encolar(nodo.getHijoIzquierdo());
					}
				}
			
			
			}
			Console.WriteLine();
		}
		
		public void incluye(int m){
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;
			bool i=true;
			int num=0;
			c.encolar(this);

			while(!c.esVacia())
			{
				arbolAux = c.desencolar();
				
				if(Convert.ToInt32(arbolAux.getDatoRaiz())!=m){
								
				if(!this.esHoja())
				{
					
					if (arbolAux.getHijoDerecho() !=null){
						
						c.encolar(arbolAux.getHijoDerecho());
					}
				
					if (arbolAux.getHijoIzquierdo() !=null){
						c.encolar(arbolAux.getHijoIzquierdo());
					}	
				   
				}
				}
				else{
					
					Console.WriteLine(i);
					num++;
				}
			}
			if (num==0){
				Console.WriteLine(i=false);
			}
			
			
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
			
			Cola<ArbolBinario<T>> q = new Cola<ArbolBinario<T>>();
			q.encolar(this);
			int nivelActual=0;
			while (!q.esVacia()){
				
				int elementoNivel=q.cantElem();
				
				while(elementoNivel-->0){
					ArbolBinario<T> nodo=q.desencolar();
					
					if (nivelActual >= n && nivelActual<=m){
						Console.WriteLine("Nivel {0}:", nivelActual);
						Console.Write(nodo.getDatoRaiz() +" ");
						Console.Write("");
					}
					
					if (nodo.getHijoDerecho() !=null){
						q.encolar(nodo.getHijoDerecho());
					}
				
					if (nodo.getHijoIzquierdo() !=null){
						q.encolar(nodo.getHijoIzquierdo());
					}
					
				}
				nivelActual++;
			
			}
			Console.WriteLine();
		}
	}
}
