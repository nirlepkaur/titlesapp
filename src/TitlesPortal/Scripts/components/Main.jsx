


var Main = React.createClass({

    getInitialState: function () {
        return {titles: []};
    },

    displayTitles: function(titleList) {
        this.setState({ titles: titleList });
    },
    render: function() {
        var titleList = this.state.titles.map(function (titles) {
            return (<TitleInfo TitleDesc={titles } />);
    });
return (
  <div>
    <TitleForm displayTitles={this.displayTitles} />
    
    {titleList}
  </div>
    )
}
});

React.render(<Main />, document.getElementById("root"));