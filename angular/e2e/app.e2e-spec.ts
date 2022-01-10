import { testprojectTemplatePage } from './app.po';

describe('testproject App', function() {
  let page: testprojectTemplatePage;

  beforeEach(() => {
    page = new testprojectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
