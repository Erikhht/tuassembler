..\..\..\tesis -comparar "..\WSJ\wsj.g" "WSJ\Taggeado\wsj.tt" "WSJ\Mediciones\wsj_VS_wsjMaxEntWsj.l" -l "Matriz de confusion para\\WSJ$_{1}$ = WSJ original contra\\ WSJ$_{2}$ = WSJ etiquetado con MaxEnt (entrenado con WSJ)" "WSJ$_{1}$" "WSJ$_{2}$"
..\..\..\tesis -comparar "..\WSJ\wsj.g" "WSJ\Taggeado\wsj+NFI.tt" "WSJ\Mediciones\wsj_VS_wsjMaxEntWsj+NFI.l" -l "Matriz de confusion para\\WSJ$_{1}$ = WSJ original contra\\NFI$_{1}$ = WSJ etiquetado con MaxEnt (entrenado con WSJ + NFI)" "WSJ$_{1}$" "NFI$_{1}$"
..\..\..\tesis -comparar "WSJ\Taggeado\wsj.tt" "WSJ\Taggeado\wsj+NFI.tt" "WSJ\Mediciones\wsjMaxEntWsj_VS_wsjMaxEntWsj+NFI.l" -l "Matriz de confusion para\\WSJ$_{2}$ = WSJ etiquetado con MaxEnt (entrenado con WSJ) vs\\NFI$_{1}$ = WSJ etiquetado con MaxEnt (entrenado con WSJ + NFI)" "WSJ$_{2}$" "NFI$_{1}$"

..\..\..\tesis -comparar "..\WSJ\wsjM1.g" "WSJ\Taggeado\wsjM1.tt" "WSJ\Mediciones\wsjM1_VS_MaxEntWsjM2.l" -l "Matriz de confusion para\\WSJ$_{3}$ = 1 mitad WSJ original contra\\ME$_{1}$ = 1 mitad WSJ etiquetado con MaxEnt (entrenado con 2 mitad de WSJ)" "WSJ$_{3}$" "ME$_{1}$"
..\..\..\tesis -comparar "..\WSJ\wsjM2.g" "WSJ\Taggeado\wsjM2.tt" "WSJ\Mediciones\wsjM2_VS_MaxEntWsjM1.l" -l "Matriz de confusion para\\WSJ$_{4}$ = 2 mitad WSJ original contra\\ME$_{2}$ = 2 mitad WSJ etiquetado con MaxEnt (entrenado con 1 mitad de WSJ)" "WSJ$_{4}$" "ME$_{2}$"

..\..\..\tesis -comparar "..\WSJ\wsjM1.g" "WSJ\Taggeado\wsjM1+NFI.tt" "WSJ\Mediciones\wsjM1_VS_MaxEntWsjM2+NFI.l" -l "Matriz de confusion para\\WSJ$_{3}$ = 1 mitad WSJ original contra\\NFI$_{2}$ = 1 mitad WSJ etiquetado con MaxEnt (entrenado con 2 mitad de WSJ + NFI)" "WSJ$_{3}$" "NFI$_{2}$"
..\..\..\tesis -comparar "..\WSJ\wsjM2.g" "WSJ\Taggeado\wsjM2+NFI.tt" "WSJ\Mediciones\wsjM2_VS_MaxEntWsjM1+NFI.l" -l "Matriz de confusion para\\WSJ$_{4}$ = 2 mitad WSJ original contra\\NFI$_{3}$ = 2 mitad WSJ etiquetado con MaxEnt (entrenado con 1 mitad de WSJ)" "WSJ$_{4}$" "NFI$_{3}$"

..\..\..\tesis -comparar "WSJ\Taggeado\wsjM1.tt" "WSJ\Taggeado\wsjM1+NFI.tt" "WSJ\Mediciones\wsjM1__MaxEntWsjM2_vs_MaxEntWsjM2+NFI.l" -l "Matriz de confusion para\\ME$_{1}$ = 1 mitad WSJ etiquetado por MaxEnt (entrenado con 2 mitad WSJ) vs\\NFI$_{2}$ = 1 mitad WSJ etiquetado con MaxEnt (entrenado con 2 mitad de WSJ + NFI)" "ME$_{1}$" "NFI$_{2}$"
..\..\..\tesis -comparar "WSJ\Taggeado\wsjM2.tt" "WSJ\Taggeado\wsjM2+NFI.tt" "WSJ\Mediciones\wsjM2__MaxEntWsjM1_vs_MaxEntWsjM1+NFI.l" -l "Matriz de confusion para\\ME$_{2}$ = 2 mitad WSJ etiquetado por MaxEnt (entrenado con 1 mitad WSJ) vs\\TnT$_{3}$ = 2 mitad WSJ etiquetado con MaxEnt (entrenado con 1 mitad de WSJ + NFI)" "ME$_{2}$" "NFI$_{3}$"