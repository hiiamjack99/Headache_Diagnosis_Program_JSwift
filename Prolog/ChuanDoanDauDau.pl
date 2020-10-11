% Author: Dinh Quoc Tuan

go :-
	intro,
	reset_answers,
	find_diagnose(Benhdaudau),
	treatment(Benhdaudau), nl.


intro :-
	write('ban cam thay nhu the nao?'), nl,
	write('De tra loi, nhap vao so ben canh cau tra loi va ket thuc bang dau (.)'), nl, nl.

find_diagnose(Benhdaudau) :-
	diagnose(Benhdaudau), !.

% Luu tru cau tra loi
% dynamic dinh nghia cac vi tu co the thay doi trong qua trinh thuc thi.

:- dynamic(progress/2).


% xoa tien trinh duoc luu tru

reset_answers :-
	retract(progress(_, _)),
	fail.
reset_answers.

% Cac luat

%dau dau cang thang

diagnose(daudaucangthang) :-
	vungdau(tran),
	trieuchunga(thaiduong),
	trieuchungb(cham).

diagnose(daudaucangthang):-
	vungdau(tran),
	trieuchunga(thaiduong),
	trieuchungb(loau).

diagnose(daudaucangthang) :-
	vungdau(tran),
	trieuchunga(matngu).

diagnose(daudaucangthang) :-
	vungdau(tran),
	trieuchunga(utai).

diagnose(daudaucangthang) :-
	vungdau(tran),
	trieuchunga(ngatmui),
	trieuchungb(domat).

% dau dau nua dau

diagnose(daunuadau) :-
	vungdau(nuadau).


diagnose(daunuadau) :-
	vungdau(tran),
	trieuchunga(utai),
	trieuchungb(buonnon).

diagnose(daunuadau) :-
	vungdau(tran),
	trieuchunga(thaiduong),
	trieuchungb(loau).

% dau dau tung cum

diagnose(daudautungcum) :-
	vungdau(saumat),
	trieuchunga(ngatmui),
	trieuchungb(domat).

diagnose(daudautungcum) :-
	vungdau(tran),
	trieuchunga(ngatmui),
	trieuchungb(buonnon).

diagnose(daudautungcum) :-
	vungdau(saumat),
	trieuchunga(thaiduong).

diagnose(daudautungcum) :-
	vungdau(saumat),
	trieuchunga(thaiduong).

diagnose(daudautungcum) :-
	vungdau(saumat),
	trieuchunga(matngu).

% dau dau man tinh


diagnose(daudaumantinh) :-
	vungdau(daday),
	trieuchunga(utai).

diagnose(daudaumantinh) :-
	vungdau(daday),
	trieuchunga(ngatmui),
	trieuchungb(domat).

diagnose(daudaumantinh) :-
	vungdau(tran),
	trieuchunga(matngu).

diagnose(daudaumantinh) :-
	vungdau(daday),
	trieuchunga(matngu).

diagnose(daudaumantinh) :-
	vungdau(saumat),
	trieuchunga(utai).

diagnose(daudaumantinh) :-
	vungdau(tran),
	trieuchunga(ngatmui),
	trieuchungb(lodau).

% Cau hoi cho so so kien thuc

question(vungdau) :-
	write('Ban cam thay dau o dau?'), nl.

question(trieuchunga) :-
	write('Ban cam thay the nao?'), nl.

question(trieuchungb) :-
	write('Ban cam thay the nao nua?'), nl.

% Cau tra loi

answer(tran) :-
	write('dau o vung tran').

answer(thaiduong) :-
	write('dau o thai duong').

answer(utai) :-
	write('u tai').

answer(domat) :-
	write('do mat').

answer(cham) :-
	write('cham').

answer(buonnon) :-
	write('buon non').

answer(nuadau) :-
	write('dau nua dau').

answer(saumat) :-
	write('dau sau mat').

answer(ngatmui) :-
	write('ngat mui').

answer(matngu) :-
	write('mat ngu').

answer(daday) :-
	write('dau da day').

answer(loau) :-
	write('lo au').

% Cach dieu tri

treatment(daudaucangthang) :-
	write('Dau dau cang thang'), nl,
	write('thuoc: Indomethacin,Ketorolac,Naproxen').

treatment(daunuadau) :-
	write('Dau nua dau'), nl,
	write('thuoc: sumatriptan, dihydroergotamine, lasmitidan').

treatment(daudautungcum) :-
	write('Dau dau tung cum'), nl,
	write('thuoc: Triptans, Octreotide, Dihydroergotamine.').


treatment(daudaumantinh) :-
	write('Dau dau man tinh'), nl,
	write('thuoc: serotonin, fluoxetine, atenolol.').


% chuan doan.

vungdau(Answer) :-
	progress(vungdau, Answer).
vungdau(Answer) :-
	\+ progress(vungdau, _),
	ask(vungdau, Answer, [tran, nuadau, saumat, daday]).

trieuchunga(Answer) :-
	progress(trieuchunga, Answer).
trieuchunga(Answer) :-
	\+ progress(trieuchunga, _),
	ask(trieuchunga, Answer, [thaiduong, utai, ngatmui, matngu]).

trieuchungb(Answer) :-
	progress(trieuchungb, Answer).
trieuchungb(Answer) :-
	\+ progress(trieuchungb, _),
	ask(trieuchungb, Answer, [cham, buonnon, domat, loau]).

answers([], _).
answers([First|Rest], Index) :-
	write(Index), write(' '), answer(First), nl,
	NextIndex is Index + 1,
	answers(Rest, NextIndex).


% xuat danh sach

parse(0, [First|_], First).
parse(Index, [First|Rest], Response) :-
	Index > 0,
	NextIndex is Index - 1,
	parse(NextIndex, Rest, Response).

% Đặt câu hỏi cho người dùng và lưu câu trả lời
% asserta khang dinh mot menh de hoac su kien or luat vao csdl.

ask(Question, Answer, Choices) :-
	question(Question),
	answers(Choices, 0),
	read(Index),
	parse(Index, Choices, Response),
	asserta(progress(Question, Response)),
	Response = Answer.










