---
# Front matter
title: "Лабораторная работа #6"
subtitle: "Мандатное разграничение прав в Linux."
author: "Критский Сергей Димитриевич"

# Generic otions
lang: ru-RU
toc-title: "Содержание"

# Bibliography
bibliography: bib/cite.bib
csl: pandoc/csl/gost-r-7-0-5-2008-numeric.csl

# Pdf output format
toc: true # Table of contents
toc_depth: 2
lof: false # List of figures
lot: false # List of tables
fontsize: 12pt
linestretch: 1.5
papersize: a4
documentclass: scrreprt
## I18n
polyglossia-lang:
  name: russian
  options:
	- spelling=modern
	- babelshorthands=true
polyglossia-otherlangs:
  name: english
### Fonts
mainfont: PT Serif
romanfont: PT Serif
sansfont: PT Sans
monofont: PT Mono
mainfontoptions: Ligatures=TeX
romanfontoptions: Ligatures=TeX
sansfontoptions: Ligatures=TeX,Scale=MatchLowercase
monofontoptions: Scale=MatchLowercase,Scale=0.9
## Biblatex
biblatex: true
biblio-style: "gost-numeric"
biblatexoptions:
  - parentracker=true
  - backend=biber
  - hyperref=auto
  - language=auto
  - autolang=other*
  - citestyle=gost-numeric
## Misc options
indent: true
header-includes:
  - \linepenalty=10 # the penalty added to the badness of each line within a paragraph (no associated penalty node) Increasing the value makes tex try to have fewer lines in the paragraph.
  - \interlinepenalty=0 # value of the penalty (node) added after each line of a paragraph.
  - \hyphenpenalty=50 # the penalty for line breaking at an automatically inserted hyphen
  - \exhyphenpenalty=50 # the penalty for line breaking at an explicit hyphen
  - \binoppenalty=700 # the penalty for breaking a line at a binary operator
  - \relpenalty=500 # the penalty for breaking a line at a relation
  - \clubpenalty=150 # extra penalty for breaking after first line of a paragraph
  - \widowpenalty=150 # extra penalty for breaking before last line of a paragraph
  - \displaywidowpenalty=50 # extra penalty for breaking before last line before a display math
  - \brokenpenalty=100 # extra penalty for page breaking after a hyphenated line
  - \predisplaypenalty=10000 # penalty for breaking before a display
  - \postdisplaypenalty=0 # penalty for breaking after a display
  - \floatingpenalty = 20000 # penalty for splitting an insertion (can only be split footnote in standard LaTeX)
  - \raggedbottom # or \flushbottom
  - \usepackage{float} # keep figures where there are in the text
  - \usepackage[T2A]{fontenc} 
  - \floatplacement{figure}{H} # keep figures where there are in the text
---

# Цель работы

Развить навыки администрирования ОС Linux. Получить первое практическое знакомство с технологией SELinux. Проверить работу SELinx на практике совместно с веб-сервером Apache.

# Выполнение лабораторной работы

## Начало работы

Запустил сервер, проверил корректность запуска Apache и состояние переключателей SELinux.

![Запуск сервера](image\http_start.png){#fig:001}

![Поиск Apache](image\apache_find.png){#fig:002}

![КСостояние переключателей SELinux](image\sestatus.png){#fig:003}

Просмотрел статистику по политике

![Статистика по политике](image\policy.png){#fig:004}

## Создание веб-страницы

Создал простую Web-страницу с надписью test. Проверил ее контекст и открыл ее.

![Контекст файла с веб-страницей](image\context.png){#fig:005}

![Сама веб-страница](image\result.png){#fig:006}

Изменил контекст Web-страницы и снова попытался ее открыть.

![Изменение контекста](image\samba.png){#fig:007}

![Веб-страница](image\samba_result.png){#fig:008}



## Изменение конфигурации сервера и страницы

Поставил прослушивание 81-го порта, указал его в файле и добавил его в список портов. Успешно открыл Web-страницу с изначальным контекстом.

![Указание 81 порта](image\port_81.png){#fig:010}

![Прослушивание 81 порта](image\add_81.png){#fig:011}

Вернул все настройки по-умолчанию и удалил файл Web-страницы.

![Указание 80 порта](image\port_80.png){#fig:012}

![Удаление страницы и 81 порта](image\rm_81.png){#fig:012}

# Выводы


Я развил навыки администрирования ОС Linux, получил первое практическое знакомство с технологией SELinux и проверил работу SELinx на практике совместно с веб-сервером Apache.
