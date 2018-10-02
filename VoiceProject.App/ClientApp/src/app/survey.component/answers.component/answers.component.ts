import { Component, Input, Output, EventEmitter} from '@angular/core';

@Component({
  selector: 'app-answers',
  templateUrl: './answers.component.html',
  styleUrls: ['./answers.component.scss']
})
export class AnswersComponent {
  @Input() Answers: Array<Answer>;
  @Output() SelectedAnswerChanged = new EventEmitter();
  Select(answer: Answer) {
    this.Answers.forEach((answer) => {
      answer.selected = false;
    });
    answer.selected = true;
    this.SelectedAnswerChanged.emit(answer);
  }
}

