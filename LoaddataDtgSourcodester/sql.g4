grammar sql;

options {
    tokenVocab = sqlLexer;
     
}

start: (instruction) + EOF;
instruction:
    SELECTKW WS columns WS FROMKW WS table (WS join_clause)? (
        WS where_clause
    )? SEMI WS?;
columns: column (SEP WS column)*;
column: ALL | (TEXT (DOT TEXT)*);
table: TEXT;
where_clause: WHEREKW WS condition;
condition:
    | column comparison string
    | column comparison column
    | string comparison string
    | string comparison column; 

comparison: WS? ( equality) WS?;
equality: EQ;
less_eq_than: LT EQ;
less_than: LT;
greater_eq_than: GT EQ;
greater_than: GT;

string: QUOTE TEXT QUOTE;
join_clause:
    join_modifier WS JOINKW WS table WS ONKW WS column WS? EQ WS? column;
join_modifier: INNERKW? | LEFTKW | RIGHTKW | FULLKW;

JOINKW: 'JOIN';
ONKW: 'ON';
LEFTKW: 'LEFT';
INNERKW: 'INNER';
RIGHTKW: 'RIGHT';
FULLKW: 'FULL';
WHEREKW: 'WHERE';
SELECTKW: 'SELECT';
FROMKW: 'FROM';
LT: '<';
GT: '>';
DOT: '.';
QUOTE: '\'';
ALL: '*';
SEP: ',';
EQ: '=';
SEMI: ';';
WS: [ \n\r]+;
TEXT: [a-z]+;