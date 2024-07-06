module Views.MainView

open Feliz.ViewEngine
open HeaderView
open HomeView

let mainView = [ headerView; Html.div ([ prop.id "main"; prop.children homeView ]) ]
