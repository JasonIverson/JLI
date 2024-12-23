using System.Collections.ObjectModel;

namespace WebApp.Models.Common {
    public static class States {

        public class State {

            public String Abbreviation { get; init; } = null!;

            public String Name { get; init; } = null!;

        }

        public static readonly State ALABAMA = new State() { Abbreviation = "AL", Name = "Alabama" };
        public static readonly State ALASKA = new State() { Abbreviation = "AK", Name = "Alaska" };
        public static readonly State ARIZONA = new State() { Abbreviation = "AZ", Name = "Arizona" };
        public static readonly State ARKANSAS = new State() { Abbreviation = "AR", Name = "Arkansas" };
        public static readonly State CALIFORNIA = new State() { Abbreviation = "CA", Name = "California" };
        public static readonly State COLORADO = new State() { Abbreviation = "CO", Name = "Colorado" };
        public static readonly State CONNECTICUT = new State() { Abbreviation = "CT", Name = "Connecticut" };
        public static readonly State DELAWARE = new State() { Abbreviation = "DE", Name = "Delaware" };
        public static readonly State DISTRICT_OF_COLUMBIA = new State() { Abbreviation = "DC", Name = "District of Columbia" };
        public static readonly State FLORIDA = new State() { Abbreviation = "FL", Name = "Florida" };
        public static readonly State GEORGIA = new State() { Abbreviation = "GA", Name = "Georgia" };
        public static readonly State HAWAII = new State() { Abbreviation = "HI", Name = "Hawaii" };
        public static readonly State IDAHO = new State() { Abbreviation = "ID", Name = "Idaho" };
        public static readonly State ILLINOIS = new State() { Abbreviation = "IL", Name = "Illinois" };
        public static readonly State INDIANA = new State() { Abbreviation = "IN", Name = "Indiana" };
        public static readonly State IOWA = new State() { Abbreviation = "IA", Name = "Iowa" };
        public static readonly State KANSAS = new State() { Abbreviation = "KS", Name = "Kansas" };
        public static readonly State KENTUCKY = new State() { Abbreviation = "KY", Name = "Kentucky" };
        public static readonly State LOUISIANA = new State() { Abbreviation = "LA", Name = "Louisiana" };
        public static readonly State MAINE = new State() { Abbreviation = "ME", Name = "Maine" };
        public static readonly State MARYLAND = new State() { Abbreviation = "MD", Name = "Maryland" };
        public static readonly State MASSACHUSETTS = new State() { Abbreviation = "MA", Name = "Massachusetts" };
        public static readonly State MICHIGAN = new State() { Abbreviation = "MI", Name = "Michigan" };
        public static readonly State MINNESOTA = new State() { Abbreviation = "MN", Name = "Minnesota" };
        public static readonly State MISSISSIPPI = new State() { Abbreviation = "MS", Name = "Mississippi" };
        public static readonly State MISSOURI = new State() { Abbreviation = "MO", Name = "Missouri" };
        public static readonly State MONTANA = new State() { Abbreviation = "MT", Name = "Montana" };
        public static readonly State NEBRASKA = new State() { Abbreviation = "NE", Name = "Nebraska" };
        public static readonly State NEVADA = new State() { Abbreviation = "NV", Name = "Nevada" };
        public static readonly State NEW_HAMPSHIRE = new State() { Abbreviation = "NH", Name = "New Hampshire" };
        public static readonly State NEW_JERSEY = new State() { Abbreviation = "NJ", Name = "New Jersey" };
        public static readonly State NEW_MEXICO = new State() { Abbreviation = "NM", Name = "New Mexico" };
        public static readonly State NEW_YORK = new State() { Abbreviation = "NY", Name = "New York" };
        public static readonly State NORTH_CAROLINA = new State() { Abbreviation = "NC", Name = "North Carolina" };
        public static readonly State NORTH_DAKOTA = new State() { Abbreviation = "ND", Name = "North Dakota" };
        public static readonly State OHIO = new State() { Abbreviation = "OH", Name = "Ohio" };
        public static readonly State OKLAHOMA = new State() { Abbreviation = "OK", Name = "Oklahoma" };
        public static readonly State OREGON = new State() { Abbreviation = "OR", Name = "Oregon" };
        public static readonly State PENNSYLVANIA = new State() { Abbreviation = "PA", Name = "Pennsylvania" };
        public static readonly State PUERTO_RICO = new State() { Abbreviation = "PR", Name = "Puerto Rico" };
        public static readonly State RHODE_ISLAND = new State() { Abbreviation = "RI", Name = "Rhode Island" };
        public static readonly State SOUTH_CAROLINA = new State() { Abbreviation = "SC", Name = "South Carolina" };
        public static readonly State SOUTH_DAKOTA = new State() { Abbreviation = "SD", Name = "South Dakota" };
        public static readonly State TENNESSEE = new State() { Abbreviation = "TN", Name = "Tennessee" };
        public static readonly State TEXAS = new State() { Abbreviation = "TX", Name = "Texas" };
        public static readonly State UTAH = new State() { Abbreviation = "UT", Name = "Utah" };
        public static readonly State VERMONT = new State() { Abbreviation = "VT", Name = "Vermont" };
        public static readonly State VIRGINIA = new State() { Abbreviation = "VA", Name = "Virginia" };
        public static readonly State WASHINGTON = new State() { Abbreviation = "WA", Name = "Washington" };
        public static readonly State WEST_VIRGINIA = new State() { Abbreviation = "WV", Name = "West Virginia" };
        public static readonly State WISCONSIN = new State() { Abbreviation = "WI", Name = "Wisconsin" };
        public static readonly State WYOMING = new State() { Abbreviation = "WY", Name = "Wyoming" };

        public static readonly IReadOnlyList<State> List = new ReadOnlyCollection<State>(
            new List<State>() {
                States.ALABAMA,
                States.ALASKA,
                States.ARIZONA,
                States.ARKANSAS,
                States.CALIFORNIA,
                States.COLORADO,
                States.CONNECTICUT,
                States.DELAWARE,
                States.DISTRICT_OF_COLUMBIA,
                States.FLORIDA,
                States.GEORGIA,
                States.HAWAII,
                States.IDAHO,
                States.ILLINOIS,
                States.INDIANA,
                States.IOWA,
                States.KANSAS,
                States.KENTUCKY,
                States.LOUISIANA,
                States.MAINE,
                States.MARYLAND,
                States.MASSACHUSETTS,
                States.MICHIGAN,
                States.MINNESOTA,
                States.MISSISSIPPI,
                States.MISSOURI,
                States.MONTANA,
                States.NEBRASKA,
                States.NEVADA,
                States.NEW_HAMPSHIRE,
                States.NEW_JERSEY,
                States.NEW_MEXICO,
                States.NEW_YORK,
                States.NORTH_CAROLINA,
                States.NORTH_DAKOTA,
                States.OHIO,
                States.OKLAHOMA,
                States.OREGON,
                States.PENNSYLVANIA,
                States.PUERTO_RICO,
                States.RHODE_ISLAND,
                States.SOUTH_CAROLINA,
                States.SOUTH_DAKOTA,
                States.TENNESSEE,
                States.TEXAS,
                States.UTAH,
                States.VERMONT,
                States.VIRGINIA,
                States.WASHINGTON,
                States.WEST_VIRGINIA,
                States.WISCONSIN,
                States.WYOMING
            });
    }
}
