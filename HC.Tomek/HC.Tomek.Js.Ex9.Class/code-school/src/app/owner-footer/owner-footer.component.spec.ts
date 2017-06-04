import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnerFooterComponent } from './owner-footer.component';

describe('OwnerFooterComponent', () => {
  let component: OwnerFooterComponent;
  let fixture: ComponentFixture<OwnerFooterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OwnerFooterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OwnerFooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
