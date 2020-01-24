namespace Quest

module Model =

    type Image = Image

    type Clue = {
        question: string
        image: Image option
        answers: string list
    }

    type ClueSequencing =
        | Ordered
        | Random

    type Quest = {
        name: string
        image: Image option
        clues: Clue list
    }

    type Player = {
        name: string
    }

    type Team = {
        name: string
        players: Set<Player>
    }

    type TeamProgressFunc = Team -> Clue

    type GameState =
    | NotStarted
    | InProgress of Map<Team,Clue>
    | Completed of winner:Team

    type Game = {
        teams: Set<Team>
        quest: Quest
        state: GameState
    }


