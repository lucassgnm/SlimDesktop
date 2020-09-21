﻿/* 
 * Formatar CNPJ, CPF e Retirar a Formatação
 * 
 * Visite nossa página http://www.codigoexpresso.com.br
 * 
 * by Antonio Azevedo
 *  
 * public static string FormatCNPJ(string CNPJ)
 *        Formata uma string CNPJ 
 *        Informar uma string sem formatacao com o codigo do CNPJ 
 *        Exemplo '11222333000181' 
 *
 * public static string FormatCPF(string CPF)
 *        Formata uma string CPF 
 *        Informar uma string sem formatacao com o codigo do CPF 
 *        Exemplo '01122233344'
 *        
 * public static string SemFormatacao(string Codigo)
 *        Retira formatacao de uma string CNPJ ou CPF 
 *        Informar uma string formatada com o codigo do CNPJ ou CPF 
 *        Exemplo '99.999.999/9999-99' ou '111.222.333-44'
 *        
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class FormatCnpjCpf
{
    /// <summary>
    /// Formatar uma string CNPJ
    /// </summary>
    /// <param name="CNPJ">string CNPJ sem formatacao</param>
    /// <returns>string CNPJ formatada</returns>
    /// <example>Recebe '99999999999999' Devolve '99.999.999/9999-99'</example>

    public static string FormatCNPJ(string CNPJ)
    {
        return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
    }

    /// <summary>
    /// Formatar uma string CPF
    /// </summary>
    /// <param name="CPF">string CPF sem formatacao</param>
    /// <returns>string CPF formatada</returns>
    /// <example>Recebe '99999999999' Devolve '999.999.999-99'</example>

    public static string FormatCPF(string CPF)
    {
        return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
    }
    /// <summary>
    /// Retira a Formatacao de uma string CNPJ/CPF
    /// </summary>
    /// <param name="Codigo">string Codigo Formatada</param>
    /// <returns>string sem formatacao</returns>
    /// <example>Recebe '99.999.999/9999-99' Devolve '99999999999999'</example>

    public static string SemFormatacao(string Codigo)
    {
        return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
    }

    public static string formatTelefone(string strNumero)
    {
        // por omissão tem 10 ou menos dígitos
        string strMascara = "{0:(00) 0000-0000}";
        // converter o texto em número
        long lngNumero = Convert.ToInt64(strNumero);

        if (strNumero.Length == 11)
            strMascara = "{0:(00) 00000-0000}";

        return string.Format(strMascara, lngNumero);
    }
}