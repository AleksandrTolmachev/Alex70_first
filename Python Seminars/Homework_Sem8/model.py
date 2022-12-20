# Модуль для выполнения опреаций
from sympy import *
import sympy
import view

def execute_expr(expr: str) -> str:         # (5+3)*10 -> 80
    """"Принимает на вход строку-пример. Возвращает результат примера."""
    sol = sympy.simplify(expr)
    return sol


def solve_eq(expr: str) -> str:                         # x**3 - 8 = 0 -> "2"                                         
    """Принимает на вход уравнение в виде строки.       
    Возвращает список корней уравнения в строку с разделителем""" 
    x = sympy.symbols('x', real=True)                             # x**2 - 1 = 0 -> "1,-1"
    roots = sympy.solve((expr, 0), x)
    return roots
    

def simpify_pol(expr: str) -> str:           # x**2 + 3*x**2 + 4 -> 4*x**2 + 4
    """"Упрощает введенный многочлен"""
    sim_fy = sympy.simplify(expr)
    return sim_fy