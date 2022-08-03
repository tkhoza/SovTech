import { SovTechTemplatePage } from './app.po';

describe('SovTech App', function() {
  let page: SovTechTemplatePage;

  beforeEach(() => {
    page = new SovTechTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
