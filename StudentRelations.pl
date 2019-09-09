student(lars, mat).
student(tom, dan).
student(liz, mat).
student(ann, dan).
student(kim, bio).
student(kim, mat).
student(pat, bio).

room(101, mat).
room(102, dan).
room(103, bio).

starts(mat, 12).
starts(dan, 09).
starts(bio, 08).

class(mat).
class(dan).
class(bio).



female(liz).
female(pat).
female(ann).

male(lars).
male(tom).
male(kim).

studentInRoom(X, S) :-
  room(S, P),
  student(X, P).

whoStartsWhen(X, T) :-
  starts(P, T),
  student(X, P).
