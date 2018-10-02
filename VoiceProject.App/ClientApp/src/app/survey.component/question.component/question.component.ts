import { Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements OnInit {
  current: number = 0;
  public Question: Question;
  @Input() Questions: Array<Question>;
  level: string = "";

  ngOnInit() {
    this.Question = this.Questions[0];
  }

  Move(step: number) {
    this.current = this.current + step;
    this.Question = this.Questions[this.current];
  }

  SelectedAnswerChanged($event) {
    this.Questions[this.current].selectedAnswer = $event;
    let value = $event.value;
    this.level = value > this.Question.minimumValueAccepted ? "Good":
      value == this.Question.minimumValueAccepted ? "Fair" :"Low";
  }
}

