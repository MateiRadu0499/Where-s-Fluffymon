Ò
pC:\Users\Ioana\Desktop\fluffy moon\Where-s-Fluffymon\FluffymonPWA\FluffymonPWA.ComponentsLibrary\LocalStorage.cs
	namespace 	
FluffymonPWA
 
. 
ComponentsLibrary (
{ 
public 

static 
class 
LocalStorage $
{ 
public 
static 
	ValueTask 
<  
T  !
>! "
GetAsync# +
<+ ,
T, -
>- .
(. /

IJSRuntime/ 9
	jsRuntime: C
,C D
stringE K
keyL O
)O P
=>		 
	jsRuntime		 
.		 
InvokeAsync		 $
<		$ %
T		% &
>		& '
(		' (
$str		( @
,		@ A
key		B E
)		E F
;		F G
public 
static 
	ValueTask 
SetAsync  (
(( )

IJSRuntime) 3
	jsRuntime4 =
,= >
string? E
keyF I
,I J
objectK Q
valueR W
)W X
=> 
	jsRuntime 
. 
InvokeVoidAsync (
(( )
$str) A
,A B
keyC F
,F G
valueH M
)M N
;N O
public 
static 
	ValueTask 
DeleteAsync  +
(+ ,

IJSRuntime, 6
	jsRuntime7 @
,@ A
stringB H
keyI L
)L M
=> 
	jsRuntime 
. 
InvokeVoidAsync (
(( )
$str) D
,D E
keyF I
)I J
;J K
} 
} Ä
nC:\Users\Ioana\Desktop\fluffy moon\Where-s-Fluffymon\FluffymonPWA\FluffymonPWA.ComponentsLibrary\Map\Marker.cs
	namespace 	
FluffymonPWA
 
. 
ComponentsLibrary (
.( )
Map) ,
{ 
public 

class 
Marker 
{ 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
double 
X 
{ 
get 
; 
set "
;" #
}$ %
public		 
double		 
Y		 
{		 
get		 
;		 
set		 "
;		" #
}		$ %
public 
bool 
	ShowPopup 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ˆ
mC:\Users\Ioana\Desktop\fluffy moon\Where-s-Fluffymon\FluffymonPWA\FluffymonPWA.ComponentsLibrary\Map\Point.cs
	namespace 	
FluffymonPWA
 
. 
ComponentsLibrary (
.( )
Map) ,
{ 
public 

class 
Point 
{ 
public 
double 
X 
{ 
get 
; 
set "
;" #
}$ %
public 
double 
Y 
{ 
get 
; 
set "
;" #
}$ %
} 
}		 