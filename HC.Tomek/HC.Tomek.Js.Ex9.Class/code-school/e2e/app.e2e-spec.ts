import { CodeSchoolPage } from './app.po';

describe('code-school App', () => {
  let page: CodeSchoolPage;

  beforeEach(() => {
    page = new CodeSchoolPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
