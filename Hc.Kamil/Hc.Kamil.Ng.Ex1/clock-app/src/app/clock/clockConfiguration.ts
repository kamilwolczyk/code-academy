export enum ClockType {
  Small,
  Medium,
  Large
}

export class ClockConfiguration {
  constructor(public displaySeconds: boolean, public type: ClockType) { }
}
