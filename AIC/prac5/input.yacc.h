/* A Bison parser, made by GNU Bison 3.8.2.  */

/* Bison interface for Yacc-like parsers in C

   Copyright (C) 1984, 1989-1990, 2000-2015, 2018-2021 Free Software Foundation,
   Inc.

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <https://www.gnu.org/licenses/>.  */

/* As a special exception, you may create a larger work that contains
   part or all of the Bison parser skeleton and distribute that work
   under terms of your choice, so long as that work isn't itself a
   parser generator using the skeleton or a modified version thereof
   as a parser skeleton.  Alternatively, if you modify or redistribute
   the parser skeleton itself, you may (at your option) remove this
   special exception, which will cause the skeleton and the resulting
   Bison output files to be licensed under the GNU General Public
   License without this special exception.

   This special exception was added by the Free Software Foundation in
   version 2.2 of Bison.  */

/* DO NOT RELY ON FEATURES THAT ARE NOT DOCUMENTED in the manual,
   especially those whose name start with YY_ or yy_.  They are
   private implementation details that can be changed or removed.  */

#ifndef YY_YY_INPUT_YACC_H_INCLUDED
# define YY_YY_INPUT_YACC_H_INCLUDED
/* Debug traces.  */
#ifndef YYDEBUG
# define YYDEBUG 0
#endif
#if YYDEBUG
extern int yydebug;
#endif

/* Token kinds.  */
#ifndef YYTOKENTYPE
# define YYTOKENTYPE
  enum yytokentype
  {
    YYEMPTY = -2,
    YYEOF = 0,                     /* "end of file"  */
    YYerror = 256,                 /* error  */
    YYUNDEF = 257,                 /* "invalid token"  */
    NL = 258,                      /* NL  */
    T_INT_LIT = 259,               /* T_INT_LIT  */
    T_FP_LIT = 260,                /* T_FP_LIT  */
    T_ALPHANUM = 261,              /* T_ALPHANUM  */
    T_STRING = 262,                /* T_STRING  */
    REG_INT = 263,                 /* REG_INT  */
    REG_FP = 264,                  /* REG_FP  */
    DE_DATA = 265,                 /* DE_DATA  */
    DE_TEXT = 266,                 /* DE_TEXT  */
    DE_SPACE = 267,                /* DE_SPACE  */
    DE_GLOBL = 268,                /* DE_GLOBL  */
    DE_IREG = 269,                 /* DE_IREG  */
    DE_FREG = 270,                 /* DE_FREG  */
    DE_ASCIIZ = 271,               /* DE_ASCIIZ  */
    DE_BTB = 272,                  /* DE_BTB  */
    DE_BYTE = 273,                 /* DE_BYTE  */
    DE_HALF = 274,                 /* DE_HALF  */
    DE_WORD = 275,                 /* DE_WORD  */
    DE_DWORD = 276,                /* DE_DWORD  */
    DE_FLOAT = 277,                /* DE_FLOAT  */
    DE_DOUBLE = 278,               /* DE_DOUBLE  */
    FORM_INM = 279,                /* FORM_INM  */
    FORM_INM_L = 280,              /* FORM_INM_L  */
    FORM_INM_S = 281,              /* FORM_INM_S  */
    FORM_INM_HI = 282,             /* FORM_INM_HI  */
    FORM_INM_LO = 283,             /* FORM_INM_LO  */
    FORM_INM_B = 284,              /* FORM_INM_B  */
    FORM_INM_B_FI = 285,           /* FORM_INM_B_FI  */
    FORM_INM_B_FFI = 286,          /* FORM_INM_B_FFI  */
    FORM_INM_T = 287,              /* FORM_INM_T  */
    INST_NOP = 288,                /* INST_NOP  */
    INST_RET = 289,                /* INST_RET  */
    INST_SYSCALL = 290,            /* INST_SYSCALL  */
    FORM_REG = 291,                /* FORM_REG  */
    FORM_REG_FF = 292,             /* FORM_REG_FF  */
    FORM_INM_FP_L = 293,           /* FORM_INM_FP_L  */
    FORM_INM_FP_S = 294,           /* FORM_INM_FP_S  */
    FORM_FP_REG = 295,             /* FORM_FP_REG  */
    FORM_FP_REG_FF = 296,          /* FORM_FP_REG_FF  */
    FORM_FP_REG_DF = 297,          /* FORM_FP_REG_DF  */
    FORM_REG_R_FP = 298,           /* FORM_REG_R_FP  */
    FORM_REG_FP_R = 299,           /* FORM_REG_FP_R  */
    FORM_J = 300,                  /* FORM_J  */
    FORM_J_F = 301,                /* FORM_J_F  */
    LABEL = 302,                   /* LABEL  */
    PINST_LA = 303,                /* PINST_LA  */
    PINST_LI = 304,                /* PINST_LI  */
    M_LO = 305,                    /* M_LO  */
    M_HI = 306,                    /* M_HI  */
    M_DISP = 307                   /* M_DISP  */
  };
  typedef enum yytokentype yytoken_kind_t;
#endif

/* Value type.  */
#if ! defined YYSTYPE && ! defined YYSTYPE_IS_DECLARED
union YYSTYPE
{
#line 95 "input.yacc.y"

    double fvalue;
    int64_t ivalue;
    char cvalue[128];

#line 122 "input.yacc.h"

};
typedef union YYSTYPE YYSTYPE;
# define YYSTYPE_IS_TRIVIAL 1
# define YYSTYPE_IS_DECLARED 1
#endif


extern YYSTYPE yylval;


int yyparse (void);


#endif /* !YY_YY_INPUT_YACC_H_INCLUDED  */
