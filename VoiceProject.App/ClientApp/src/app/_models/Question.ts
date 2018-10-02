interface Question {
  id: number;
  title: string;
  body: string;
  order: number;
  minimumValueAccepted: number;
  answers: Array<Answer>;
  selectedAnswer: Answer;
}
