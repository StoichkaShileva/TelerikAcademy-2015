function solve() {
    var specialID = 0;

    function checkNameTitleAuthor(str) {
        if (str.length < 3 || str.length > 25) {
            throw new Error();
        } else {
            return true;
        }
    }
    var playable = (function() {
        function Playable(title, author) {
            this.id = ++specialID;
            if (checkNameTitleAuthor(title) === true && checkNameTitleAuthor(author) === true) {
                this.title = title;
                this.author = author;
            }
        }
        Object.defineProperties(Playable, {
            title: {
                get: function() {
                    return this.title;
                },
                set: function(val) {
                    if (checkNameTitleAuthor(val) === true) {
                        this.title = title;
                    }
                },
                configurable: true
            },
            author: {
                get: function() {
                    return this.author;
                },
                set: function(val) {
                    if (checkNameTitleAuthor(val) === true) {
                        this.author = author;
                    }
                },
                configurable: true
            },
            id: {
                get: function () {
                    return this.id;
                }
            }
        });
        Playable.prototype.play = function() {
            return this.id + '. ' + this.title + ' - ' + this.author;
        };
        return Playable;
    })();
    var module = {
        getPlayer: function(name) {
            function Player(name) {
                if (checkNameTitleAuthor(name) === true) {
                    this.name = name;
                }
                this.playlists = [];
            }
            Object.defineProperty(Player, 'name', {
                get: function() {
                    return this.name;
                },
                set: function(val) {
                    if (checkNameTitleAuthor(val) === true) {
                        this.name = name;
                    }
                },
                configurable: true
            });
            Player.prototype.addPlayPlist = function(playlist) {
                this.playlists.push(playlist);
                return this;
            };
            Player.prototype.getPlaylistById = function(ID) {
                var playListToReturn = undefined;
                for (var i = 0; i < this.playlists.length; i += 1) {
                    if (this.playlists[i].id === ID) {
                        playListToReturn = this.playlists[i];
                        break;
                    }
                }
                if (playListToReturn == undefined) {
                    return null;
                } else {
                    return playListToReturn;
                }
            };
            Player.prototype.removePlaylist = function(idOrPlaylist) {
                var isRemoved = false;

                function isNumeric(n) {
                    return !isNaN(parseFloat(n)) && isFinite(n);
                }
                var isID = isNumeric(idOrPlaylist);
                if (isID === true) {
                    for (var i = 0; i < this.playlists.length; i += 1) {
                        if (this.playlists[i].id === idOrPlaylist) {
                            this.playlists.splice(i, 1);
                            isRemoved = true;
                            break;
                        }
                    }
                } else {
                    for (var i = 0; i < this.playlists.length; i += 1) {
                        if (this.playlists[i] === idOrPlaylist) {
                            this.playlists.splice(i, 1);
                            isRemoved = true;
                            break;
                        }
                    }
                }
                if (!isRemoved) {
                    throw new Error();
                }
                return this;
            };
            Player.prototype.listPlaylists = function(page, size) {

            };
            Player.prototype.contains = function(playable, playlist) {

            };
            return Player;
        },
        getPlaylist: function(name) {
            function PlayList(name) {
                this.currentID = ++specialID;
                if (checkNameTitleAuthor(name) === true) {
                    this.name = name;
                }
                this.playlist = [];
            }
            Object.defineProperty(Player, 'name', {
                get: function() {
                    return this.name;
                },
                set: function(val) {
                    if (checkNameTitleAuthor(val) === true) {
                        this.name = name;
                    }
                },
                configurable: true
            });
            PlayList.prototype.addPlayable = function(playbale) {
                this.playlist.push(playable);
                return this;
            };
            Player.prototype.getPlayableById = function() {
                var ID = specialID;
                var playListToReturn = undefined;
                for (var i = 0; i < this.playlist.length; i += 1) {
                    if (this.playlist[i].id === ID) {
                        playListToReturn = this.playlist[i];
                        break;
                    }
                }
                if (playListToReturn == undefined) {
                    return null;
                } else {
                    return playListToReturn;
                }
            };
            Player.prototype.removePlaylist = function(idOrPlaylist) {
                var isRemoved = false;

                function isNumeric(n) {
                    return !isNaN(parseFloat(n)) && isFinite(n);
                }
                var isID = isNumeric(idOrPlaylist);
                if (isID === true) {
                    for (var i = 0; i < this.playlists.length; i += 1) {
                        if (this.playlist[i].id === specialID) {
                            this.playlist.splice(i, 1);
                            isRemoved = true;
                            break;
                        }
                    }
                } else {
                    for (var i = 0; i < this.playlists.length; i += 1) {
                        if (this.playlist[i] === idOrPlaylist) {
                            this.playlist.splice(i, 1);
                            isRemoved = true;
                            break;
                        }
                    }
                }
                if (!isRemoved) {
                    throw new Error();
                }
                return this;
            };
            return PlayList;
        },
        getAudio: function(title, author, length) {
            function checkLength(length) {
                if (length < 1 || length > 5) {
                    throw new Error();
                } else {
                    return true;
                }
            }
            Audio.prototype = new playable(title, author);
            Audio.prototype.constructor = Audio;

            function Audio(title, author, length) {
                this.title = title;
                this.author = author;
                if (checkLength(length) === true) {
                    this.length = length;
                }
            }
            Object.defineProperty(Audio, 'length', {
                get: function() {
                    return this.length;
                },
                set: function() {
                    if (checkLength(length) === true) {
                        this.length = length;
                    }
                },
                configurable: true
            });
            Audio.prototype.play = function() {
                return this.id + '. ' + this.title + ' - ' + this.author + " - " + this.length;
            };
            return Audio;
        },
        getVideo: function(title, author, imdbRating) {
            function checkIMBDRating(rating) {
                if (rating < 1 || rating > 5) {
                    throw new Error();
                } else {
                    return true;
                }
            }
            Video.prototype = new playable(title, author);
            Video.prototype.constructor = Video;

            function Video(title, author, imdbRating) {
                this.title = title;
                this.author = author;
                if (checkIMBDRating(imdbRating) === true) {
                    this.imdbRating = imdbRating;
                }
            }
            Object.defineProperty(Video, 'imbdRating', {
                get: function() {
                    return this.imbdRating;
                },
                set: function() {
                    if (checkIMBDRating(imdbRating) === true) {
                        this.imdbRating = imdbRating;
                    }
                },
                configurable: true
            });
            Video.prototype.play = function() {
                return this.id + '. ' + this.title + ' - ' + this.author + " - " + this.imdbRating;
            };
            return Video;
        }
    };
    return module;
}

var module = solve();
module.getVideo("batal", "bumkara", 8);
console.log(module.getVideo().play());

// console.log(player = module.getPlayer('pesho'));
// playlist = module.getPlaylist('gosho');
// player.addPlaylist(playlist);
// var audio = module.getAudio('ivan', 'ivanov', 4);
// playlist.addPlayable(audio);

// console.log(player.search('van'));